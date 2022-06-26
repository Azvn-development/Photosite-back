using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using Photosite.DAL;
using Photosite.Test.Configuration;
using System;

namespace Photosite.Test
{
    public abstract class BaseTest
    {
        protected PhotositeContext _dbContext;
        protected IServiceProvider _serivceProvider;
        protected ConfigurationManager _configuration;

        [SetUp]
        public void Setup()
        {
            // Database configuration
            _dbContext = DatabaseConfiguration.GetDatabaseContext();

            // Configuration
            _configuration = ConfigConfiguration.GetConfigConfiguration();

            // Services configuration
            _serivceProvider = ServicesConfiguration.GetServicesConfiguration(_dbContext, _configuration);

            SetupInternal();
        } // Setup

        [TearDown]
        public void TearDown()
        {
            _dbContext.Database.EnsureDeleted();
        } // TearDown

        protected abstract void SetupInternal();
    }
}