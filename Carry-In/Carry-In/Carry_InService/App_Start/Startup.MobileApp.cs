using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Web.Http;
using Microsoft.Azure.Mobile.Server;
using Microsoft.Azure.Mobile.Server.Authentication;
using Microsoft.Azure.Mobile.Server.Config;
using Carry_InService.DataObjects;
using Carry_InService.Models;
using Owin;

namespace Carry_InService
{
    public partial class Startup
    {
        public static void ConfigureMobileApp(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            //For more information on Web API tracing, see http://go.microsoft.com/fwlink/?LinkId=620686 
            config.EnableSystemDiagnosticsTracing();

            new MobileAppConfiguration()
                .UseDefaultConfiguration()
                .ApplyTo(config);

            // Use Entity Framework Code First to create database tables based on your DbContext
            Database.SetInitializer(new Carry_InInitializer());

            // To prevent Entity Framework from modifying your database schema, use a null database initializer
            // Database.SetInitializer<Carry_InContext>(null);

            MobileAppSettingsDictionary settings = config.GetMobileAppSettingsProvider().GetMobileAppSettings();

            if (string.IsNullOrEmpty(settings.HostName))
            {
                // This middleware is intended to be used locally for debugging. By default, HostName will
                // only have a value when running in an App Service application.
                app.UseAppServiceAuthentication(new AppServiceAuthenticationOptions
                {
                    SigningKey = ConfigurationManager.AppSettings["SigningKey"],
                    ValidAudiences = new[] { ConfigurationManager.AppSettings["ValidAudience"] },
                    ValidIssuers = new[] { ConfigurationManager.AppSettings["ValidIssuer"] },
                    TokenHandler = config.GetAppServiceTokenHandler()
                });
            }
            app.UseWebApi(config);
        }
    }

    public class Carry_InInitializer : CreateDatabaseIfNotExists<Carry_InContext>
    {
        protected override void Seed(Carry_InContext context)
        {
            List<FoodItem> FoodItems = new List<FoodItem>
            {
                new FoodItem { Id = Guid.NewGuid().ToString(), Description="Maybe this is why it doesn't work?", IconCacheUri="blah", Name="Orange", Price=10.00m, Ingredients="An orange", IconUri="https://d3nevzfk7ii3be.cloudfront.net/igi/KRLMkuaBjm5mKDDP"},
                new FoodItem { Id = Guid.NewGuid().ToString(), Description="Hello World", IconCacheUri="blah", Name="Apple", Price=5.00m, Ingredients="An apple", IconUri="https://www.google.com/url?sa=i&rct=j&q=&esrc=s&source=images&cd=&ved=0ahUKEwis8qPAlP7MAhUCax4KHScxAf0QjBwIBA&url=http%3A%2F%2Fdreamatico.com%2Fdata_images%2Fapple%2Fapple-7.jpg&bvm=bv.123325700,d.dmo&psig=AFQjCNGvAiWavIa53D701MsWQWCUTN-hgg&ust=1464572669980486" },
            };

            foreach (FoodItem FoodItem in FoodItems)
            {
                context.Set<FoodItem>().Add(FoodItem);
            }

            base.Seed(context);
        }
    }
}

