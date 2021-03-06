﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using MbDotNet.Enums;
using MbDotNet.Models;
using MbDotNet.Models.Imposters;

namespace MbDotNet.Tests.Imposters
{
    /// <summary>
    /// Summary description for ImposterTests
    /// </summary>
    [TestClass]
    public class HttpImposterTests
    {
        #region Constructor Tests

        [TestMethod]
        public void Constructor_SetsPort()
        {
            const int port = 123;
            var imposter = new HttpImposter(port, null);
            Assert.AreEqual(port, imposter.Port);
        }

        [TestMethod]
        public void Constructor_SetsProtocol()
        {
            var imposter = new HttpImposter(123, null);
            Assert.AreEqual("http", imposter.Protocol);
        }

        [TestMethod]
        public void Constructor_SetsName()
        {
            const string expectedName = "Service";
            var imposter = new HttpImposter(123, expectedName);
            Assert.AreEqual(expectedName, imposter.Name);
        }

        [TestMethod]
        public void Constructor_PendingSubmissionUponCreation()
        {
            var imposter = new HttpImposter(123, null);
            Assert.IsTrue(imposter.PendingSubmission);
        }

        [TestMethod]
        public void Constructor_InitializesStubsCollection()
        {
            var imposter = new HttpImposter(123, null);
            Assert.IsNotNull(imposter.Stubs);
        }

        #endregion

        #region Stub Tests

        [TestMethod]
        public void AddStub_AddsStubToCollection()
        {
            var imposter = new HttpImposter(123, null);
            imposter.AddStub();
            Assert.AreEqual(1, imposter.Stubs.Count);
        }

        #endregion
    }
}
