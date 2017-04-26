using Microsoft.VisualStudio.TestTools.UnitTesting;
using EEPrep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using System.Data;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace EEPrep.Tests
{
    [TestClass()]
    public class MySqlDataProviderTests
    {
        private MySqlDataProvider mySqlDataProvider;
        private Mock<MySqlDatabaseConnection> mockConnection;
        private Mock<IDbCommand> mockSqlCommand;
        private Mock<IDataReader> mockDataReader;

        [TestInitialize]
        public void InitailizeTest()
        {
            mockConnection = new Mock<MySqlDatabaseConnection>();
            mockSqlCommand = new Mock<IDbCommand>();
            mockDataReader = new Mock<IDataReader>();
            mySqlDataProvider = new MySqlDataProvider(mockConnection.Object);
            mockConnection.Setup(instance => instance.CreateCommand()).Returns(mockSqlCommand.Object);
        }

        [TestMethod()]
        public void ExecuteReaderTest()
        {
            mockConnection.Setup(instance => instance.State).Returns(ConnectionState.Closed);
            // set the command up so that it returns the data reader when it executes the command
            mockSqlCommand.Setup(instance => instance.ExecuteReader()).Returns(mockDataReader.Object);
            //act

            IDataReader actualDataReader = mySqlDataProvider.ExecuteReader("");
  
            // verify that openn connection was called
            mockConnection.Verify(instance => instance.OpenConnection());
            Assert.AreEqual(mockDataReader.Object, actualDataReader);
        }

        [TestMethod()]
        public void ExecuteScalarTest()
        {
            //verifies that the command was actually called
            object expectedObject = 0;
            mockSqlCommand.Setup(instance => instance.ExecuteScalar()).Returns(expectedObject);

            object actualObject = mySqlDataProvider.ExecuteScalar("");

            Assert.AreEqual(expectedObject, actualObject);
        }
    }
}