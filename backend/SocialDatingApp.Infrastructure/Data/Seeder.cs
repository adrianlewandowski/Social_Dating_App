﻿using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SocialDatingApp.Core;
using SocialDatingApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialDatingApp.Infrastructure.Data
{
    public static class Seeder
    {
        public static void SeedData(IApplicationBuilder builder)
        {
            using (var serviceScope = builder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                using (var transaction = context.Database.BeginTransaction())
                {
                    if (!context.Users.Any())
                    {
                        context.Users.AddRange(new List<User>()
                        {
                            new User
                            {
                                Id = "900ecda1-f34c-4fc0-8282-d9871f514e5f",
                                FirstName = "Geralt",
                                LastName = "Z Rivii",
                                UserName = "Geralt",
                                NormalizedUserName = "GERALT",
                                Email = "geralt.rivia@wyzima.com",
                                NormalizedEmail = "GERALT.RIVIA@WYZIMA.COM",
                                Age = 25,
                                Localization = "Kaer Morhen",
                                EmailConfirmed = false,
                                PasswordHash = "AQAAAAEAACcQAAAAEJqklDpdP+gBn9mjGhF5YbI59sm2b/nTaFqOwJUSCxTddPkHeY3p0CtE7yBZlUbtUg==", // Password = Wyzima1@
                                SecurityStamp = "QYCRUXSDCYH5GDNEHDK2CX4A22YVMZS2",
                                ConcurrencyStamp = "512b36d3-4876-48a8-8d27-a882b13c1bfd",
                                PhoneNumberConfirmed = false,
                                TwoFactorEnabled = false,
                                LockoutEnabled = false,
                                AccessFailedCount = 0,
                                LookingFor = "Money, girls and monsters",
                                Description = "Mutated monster-hunter for hire, journeys toward his destiny in a turbulent world where people often prove more wicked than beasts",
                                Interests = "Playing guitar"
                            },
                            new User
                            {
                                Id = "1950ebbc-a093-422b-af5f-22521e88f45f",
                                FirstName = "Yennefer",
                                LastName = "Z Vengerbergu",
                                UserName = "Yennefer",
                                NormalizedUserName = "YENNEFER",
                                Email = "yennefer.vengerberg@wyzima.com",
                                NormalizedEmail = "YENNEFER.VENGERBERG@WYZIMA.COM",
                                Age = 22,
                                Localization = "Velen",
                                EmailConfirmed = false,
                                PasswordHash = "AQAAAAEAACcQAAAAEFocob1MtZCfgqScOc3p2StReFOYfCe75biZciqZYo76mXZHd5SmcGByzaGvdEthYA==", // Password = Wyzima1@
                                SecurityStamp = "2YPMWBMDJB2OVGU7HLCZBZUKUYTVMJNF",
                                ConcurrencyStamp = "8594d5c4-4160-4d49-9a42-6ce70ccf9286",
                                PhoneNumberConfirmed = false,
                                TwoFactorEnabled = false,
                                LockoutEnabled = false,
                                AccessFailedCount = 0,
                                LookingFor = "Nice man with white hair",
                                Description = "I'm young, nice looking witch",
                                Interests = "Magic and music"
                            },
                            new User
                            {
                                Id = "8222f166-68df-4397-ad33-89d00f86a3f5",
                                FirstName = "Vesemir",
                                LastName = "Z Kaer Morhen",
                                UserName = "Vesemir",
                                NormalizedUserName = "VESEMIR",
                                Email = "vesemir.wiedzmin@wyzima.com",
                                NormalizedEmail = "VESEMIR.WIEDZMIN@WYZIMA.COM",
                                Age = 55,
                                Localization = "Kaer Morhen",
                                EmailConfirmed = false,
                                PasswordHash = "AQAAAAEAACcQAAAAEAna/KiSG45Ep6aAtbgDHRuClHQNrChsuH7XsMVxT4024rV7Jn1DJYQvwGF4OPhMhA==", // Password = Wyzima1@
                                SecurityStamp = "SZRAE53IC2JCJXOAV6ZDMUYZLMYRQGYP",
                                ConcurrencyStamp = "8a74aa2c-ac89-4e39-9aeb-ae6798022819",
                                PhoneNumberConfirmed = false,
                                TwoFactorEnabled = false,
                                LockoutEnabled = false,
                                AccessFailedCount = 0,
                                LookingFor = "I don't know, let's see what will happened",
                                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec euismod est et elit pharetra commodo. Vestibulum iaculis risus et risus consequat, a gravida lacus pulvinar. Duis sit amet enim ultricies, vulputate est quis, vehicula dolor. Nunc quis felis tincidunt, ultricies dolor a, aliquet lacus. In sollicitudin sollicitudin sem eu accumsan. Aenean aliquet eros ligula, non efficitur mi finibus vel. Integer sagittis nulla vitae nulla ornare consectetur. Aliquam id orci eu arcu scelerisque tempus ut ac diam. Duis tortor metus, consequat non dui ut, facilisis posuere odio. Nunc elementum urna sed elementum pretium. Quisque pretium magna nec est dapibus, ut imperdiet odio semper. Nulla eu aliquet odio. Mauris a sollicitudin enim, in lacinia turpis. Nunc quis eros facilisis, pharetra diam ut, varius nisi. Donec ultrices nec massa a pulvinar. Sed tincidunt lorem non luctus laoreet. In ac erat ac mi finibus sodales nec nec tellus. Nunc commodo in ligula a semper. Nunc pharetra eget velit vitae commodo. Donec eget massa at nulla ultricies consequat. Fusce tempor eu ipsum vel venenatis. Pellentesque finibus turpis ut erat aliquet gravida. Nam id lorem felis. Maecenas nec placerat est. Phasellus nunc lorem, aliquet eget metus vitae, blandit vulputate turpis. Aliquam at odio non lorem pulvinar sagittis sit amet at magna. Sed sit amet neque in sapien maximus tristique eget et dui. Nam sit amet ligula ut odio sodales feugiat et a augue. Mauris congue orci elit. Sed placerat euismod volutpat. Ut sed leo pharetra, vulputate nulla vitae, malesuada turpis. Mauris sagittis volutpat quam eget feugiat. Curabitur vel tellus nulla. Donec et sagittis elit. Nulla posuere aliquam dui ac auctor. Aenean consectetur ultricies neque a rutrum. Mauris ullamcorper dui quis aliquet rhoncus. Fusce ornare tellus eu sem commodo, nec dignissim neque tempus. Morbi ultricies placerat pellentesque. Morbi non velit faucibus, porta orci non, laoreet mi. Mauris placerat luctus faucibus. Pellentesque facilisis diam velit, sed laoreet mi venenatis non. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam tempor purus et sapien vestibulum porttitor. Aenean id eros et nulla dignissim condimentum. Vestibulum eget volutpat arcu, a vehicula tortor. Nam molestie imperdiet accumsan. Etiam quis sapien in lacus placerat faucibus quis at nunc.",
                                Interests = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec euismod est et elit pharetra commodo. Vestibulum iaculis risus et risus consequat, a gravida lacus pulvinar. Duis sit amet enim ultricies, vulputate est quis, vehicula dolor. Nunc quis felis tincidunt, ultricies dolor a, aliquet lacus. In sollicitudin sollicitudin sem eu accumsan. Aenean aliquet eros ligula, non efficitur mi finibus vel. Integer sagittis nulla vitae nulla ornare consectetur. Aliquam id orci eu arcu scelerisque tempus ut ac diam. Duis tortor metus, consequat non dui ut, facilisis posuere odio. Nunc elementum urna sed elementum pretium. Quisque pretium magna nec est dapibus, ut imperdiet odio semper. Nulla eu aliquet odio. Mauris a sollicitudin enim, in lacinia turpis. Nunc quis eros facilisis, pharetra diam ut, varius nisi. Donec ultrices nec massa a pulvinar. Sed tincidunt lorem non luctus laoreet. In ac erat ac mi finibus sodales nec nec tellus. Nunc commodo in ligula a semper. Nunc pharetra eget velit vitae commodo. Donec eget massa at nulla ultricies consequat. Fusce tempor eu ipsum vel venenatis. Pellentesque finibus turpis ut erat aliquet gravida. Nam id lorem felis. Maecenas nec placerat est. Phasellus nunc lorem, aliquet eget metus vitae, blandit vulputate turpis. Aliquam at odio non lorem pulvinar sagittis sit amet at magna. Sed sit amet neque in sapien maximus tristique eget et dui. Nam sit amet ligula ut odio sodales feugiat et a augue. Mauris congue orci elit. Sed placerat euismod volutpat. Ut sed leo pharetra, vulputate nulla vitae, malesuada turpis. Mauris sagittis volutpat quam eget feugiat. Curabitur vel tellus nulla. Donec et sagittis elit. Nulla posuere aliquam dui ac auctor. Aenean consectetur ultricies neque a rutrum. Mauris ullamcorper dui quis aliquet rhoncus. Fusce ornare tellus eu sem commodo, nec dignissim neque tempus. Morbi ultricies placerat pellentesque. Morbi non velit faucibus, porta orci non, laoreet mi. Mauris placerat luctus faucibus. Pellentesque facilisis diam velit, sed laoreet mi venenatis non. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam tempor purus et sapien vestibulum porttitor. Aenean id eros et nulla dignissim condimentum. Vestibulum eget volutpat arcu, a vehicula tortor. Nam molestie imperdiet accumsan. Etiam quis sapien in lacus placerat faucibus quis at nunc."
                            },
                            new User
                            {
                                Id = "518ae485-ef25-4aee-bbec-f7f1bfff51b1",
                                FirstName = "Ciri",
                                LastName = "Riannon",
                                UserName = "Ciri",
                                NormalizedUserName = "CIRI",
                                Email = "ciri.riannon@wyzima.com",
                                NormalizedEmail = "CIRI.RIANNON@WYZIMA.COM",
                                Age = 18,
                                Localization = "Skellige",
                                EmailConfirmed = false,
                                PasswordHash = "AQAAAAEAACcQAAAAEAFFwvCsYD7YQxF2jl/4lH57aajPNUKJM9x8DDgrRNfzDVp+cJKocrVP7aYUmo/pHg==", // Password = Wyzima1@
                                SecurityStamp = "KB5A6ZWWP23BZ44LD5TRA7665TJM2T2M",
                                ConcurrencyStamp = "d479a8f5-c1ca-46dc-ac4c-28ae86784926",
                                PhoneNumberConfirmed = false,
                                TwoFactorEnabled = false,
                                LockoutEnabled = false,
                                AccessFailedCount = 0,
                                LookingFor = "Young prince",
                                Description = "Young witcheress with special powers",
                                Interests = "Slaying monsters"
                            },
                            new User
                            {
                                Id = "3826d32d-8dc1-46ae-b703-cd7653700ca3",
                                FirstName = "Jaskier",
                                LastName = "Pankratz ",
                                UserName = "Jaskier",
                                NormalizedUserName = "JASKIER",
                                Email = "jaskier.pankratz @wyzima.com",
                                NormalizedEmail = "JASKIER.PANKRATZ@WYZIMA.COM",
                                Age = 23,
                                Localization = "Biały Sad",
                                EmailConfirmed = false,
                                PasswordHash = "AQAAAAEAACcQAAAAEOUrdwmSXaJMUkYqqn+xvUiblSexCmFZtI8lFeAaOce6T7tIWzbh+fp3OCWPbu5ytw==", // Password = Wyzima1@
                                SecurityStamp = "EH7OIW2GA2OQ3JMG5F3JK2LZU6CJII5P",
                                ConcurrencyStamp = "1f23ac2a-9f91-484b-94c7-488975b3da51",
                                PhoneNumberConfirmed = false,
                                TwoFactorEnabled = false,
                                LockoutEnabled = false,
                                AccessFailedCount = 0,
                                LookingFor = "Money, girls and beautifull journeys",
                                Description = "Young fella with beautifull voice",
                                Interests = "Playing guitar, lute and singing songs about witcher."
                            },
                            new User
                            {
                                Id = "805a3c1e-9bf8-4caf-8530-174e71d44637",
                                FirstName = "Triss",
                                LastName = "Merigold",
                                UserName = "Triss",
                                NormalizedUserName = "TRISS",
                                Email = "triss.merigold@wyzima.com",
                                NormalizedEmail = "TRISS.MERIGOLD@WYZIMA.COM",
                                Age = 24,
                                Localization = "Mirthe",
                                EmailConfirmed = false,
                                PasswordHash = "AQAAAAEAACcQAAAAEAVMKBC0kOSWtCQIEZultSQWfHHpyLUcU23bPxS4K2a+6tcoVjclCOM51LQ8pAIHeQ==", // Password = Wyzima1@
                                SecurityStamp = "5DGS7YSJVXIZCKDJNHOPDHNI6TDRWBYJ",
                                ConcurrencyStamp = "c4eadd6b-18dc-496e-84d5-6990807ed7c4",
                                PhoneNumberConfirmed = false,
                                TwoFactorEnabled = false,
                                LockoutEnabled = false,
                                AccessFailedCount = 0,
                                LookingFor = "Geralt because I think he is on this app for Yennefer",
                                Description = "Young, powerfull witch",
                                Interests = "Stalking Geralt and make hate comments on Yennefer on forums"
                            },
                            new User
                            {
                                Id = "5a082b37-3f47-423a-ba4b-00add48d25be",
                                FirstName = "Fringilla",
                                LastName = "Vigo",
                                UserName = "Fringilla",
                                NormalizedUserName = "FRINGILLA",
                                Email = "fringilla.vigo@wyzima.com",
                                NormalizedEmail = "FRINGILLA.VIGO@WYZIMA.COM",
                                Age = 28,
                                Localization = "Nilfgaard",
                                EmailConfirmed = false,
                                PasswordHash = "AQAAAAEAACcQAAAAEMFLouO262jg4AmLR8ELwlN8cia551nade2Q9RWP93z14pH6hYAHbKZM/zdn/q8vMA==", // Password = Wyzima1@
                                SecurityStamp = "6RJ4XFMGS3FEUQ3YCEZRR4M5WMHCPUVN",
                                ConcurrencyStamp = "31c8196b-31b5-4bf7-97bb-e717017c070a",
                                PhoneNumberConfirmed = false,
                                TwoFactorEnabled = false,
                                LockoutEnabled = false,
                                AccessFailedCount = 0,
                                LookingFor = "Cheating",
                                Description = "Elegant, short haired witch",
                                Interests = "Cheating for nilfgaard"
                            },
                            new User
                            {
                                Id = "f4b049d4-d1ca-4bc4-bcb7-79c4f2b5f8d0",
                                FirstName = "Lambert",
                                LastName = "Krasnolud",
                                UserName = "Lambert",
                                NormalizedUserName = "LAMBERT",
                                Email = "lambert.krasnolud@wyzima.com",
                                NormalizedEmail = "LAMBERT.KRASNOLUD@WYZIMA.COM",
                                Age = 25,
                                Localization = "Lasy Wyzimy",
                                EmailConfirmed = false,
                                PasswordHash = "AQAAAAEAACcQAAAAEH/8/aSqmbzgWbgxaZfRI53FOOWaOTWywQsU8d3GbFRLoVsV5EHpXCdvhinyssM9ew==", // Password = Wyzima1@
                                SecurityStamp = "P2CIDP5J5G7YXGKRQU4XE6GBSLYCOJKB",
                                ConcurrencyStamp = "373d6f5d-286a-404e-a467-cb2c6644a2e4",
                                PhoneNumberConfirmed = false,
                                TwoFactorEnabled = false,
                                LockoutEnabled = false,
                                AccessFailedCount = 0,
                                LookingFor = "Short, dwarf woman",
                                Description = "Big guy with big muscle",
                                Interests = "Fight, gwint, alcohol"
                            },
                            new User
                            {
                                Id = "779f70ea-99d2-4fe5-bb62-a6d7278823a3",
                                FirstName = "Bruce",
                                LastName = "Wayne ",
                                UserName = "Batman",
                                NormalizedUserName = "BATMAN",
                                Email = "bruce.wayne @wyzima.com",
                                NormalizedEmail = "BRUCE.WAYNE@WYZIMA.COM",
                                Age = 29,
                                Localization = "Gotham",
                                EmailConfirmed = false,
                                PasswordHash = "AQAAAAEAACcQAAAAEOUrdwmSXaJMUkYqqn+xvUiblSexCmFZtI8lFeAaOce6T7tIWzbh+fp3OCWPbu5ytw==", // Password = Wyzima1@
                                SecurityStamp = "EH7OIW2GA2OQ3JMG5F3JK2LZU6CJII5P",
                                ConcurrencyStamp = "1f23ac2a-9f91-484b-94c7-488975b3da51",
                                PhoneNumberConfirmed = false,
                                TwoFactorEnabled = false,
                                LockoutEnabled = false,
                                AccessFailedCount = 0,
                                LookingFor = "Crime to fight with",
                                Description = "I can fly XD",
                                Interests = "Fight with criminalists in my free time"
                            },
                            new User
                            {
                                Id = "47563445-6d39-4e1b-bcb1-3638ebc913e0",
                                FirstName = "Jack",
                                LastName = "Sparrow ",
                                UserName = "Jack",
                                NormalizedUserName = "JACK",
                                Email = "jack.sparrow @wyzima.com",
                                NormalizedEmail = "JACK.SPARROW@WYZIMA.COM",
                                Age = 39,
                                Localization = "Tortuga",
                                EmailConfirmed = false,
                                PasswordHash = "AQAAAAEAACcQAAAAEOUrdwmSXaJMUkYqqn+xvUiblSexCmFZtI8lFeAaOce6T7tIWzbh+fp3OCWPbu5ytw==", // Password = Wyzima1@
                                SecurityStamp = "EH7OIW2GA2OQ3JMG5F3JK2LZU6CJII5P",
                                ConcurrencyStamp = "1f23ac2a-9f91-484b-94c7-488975b3da51",
                                PhoneNumberConfirmed = false,
                                TwoFactorEnabled = false,
                                LockoutEnabled = false,
                                AccessFailedCount = 0,
                                LookingFor = "Arrrrrrr",
                                Description = "Maybe I'm the worst pirate ever, but you hear about me! That's count!",
                                Interests = "Sailing"
                            },
                            new User
                            {
                                Id = "65e93120-d18f-440a-bd4e-2898f1b973e4",
                                FirstName = "Lara",
                                LastName = "Croft ",
                                UserName = "Lara",
                                NormalizedUserName = "LARA",
                                Email = "lara.croft @wyzima.com",
                                NormalizedEmail = "LARA.CROFT@WYZIMA.COM",
                                Age = 23,
                                Localization = "Grobowiec",
                                EmailConfirmed = false,
                                PasswordHash = "AQAAAAEAACcQAAAAEOUrdwmSXaJMUkYqqn+xvUiblSexCmFZtI8lFeAaOce6T7tIWzbh+fp3OCWPbu5ytw==", // Password = Wyzima1@
                                SecurityStamp = "EH7OIW2GA2OQ3JMG5F3JK2LZU6CJII5P",
                                ConcurrencyStamp = "1f23ac2a-9f91-484b-94c7-488975b3da51",
                                PhoneNumberConfirmed = false,
                                TwoFactorEnabled = false,
                                LockoutEnabled = false,
                                AccessFailedCount = 0,
                                LookingFor = "Freak guy with own ship",
                                Description = "Young millionaire who loves adventures",
                                Interests = "Treasures and adventures"
                            },
                        });

                        
                    }

                    context.SaveChanges();

                    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Connection ON;");

                    if (!context.Set<Connection>().Any())
                    {
                        context.Set<Connection>().AddRange(
                            new Connection
                            {
                                ConnectionId = 1,
                                UserId1 = "900ecda1-f34c-4fc0-8282-d9871f514e5f",
                                UserId2 = "1950ebbc-a093-422b-af5f-22521e88f45f"
                            },
                            new Connection
                            {
                                ConnectionId = 2,
                                UserId1 = "900ecda1-f34c-4fc0-8282-d9871f514e5f",
                                UserId2 = "805a3c1e-9bf8-4caf-8530-174e71d44637"
                            },
                            new Connection
                            {
                                ConnectionId = 3,
                                UserId1 = "900ecda1-f34c-4fc0-8282-d9871f514e5f",
                                UserId2 = "518ae485-ef25-4aee-bbec-f7f1bfff51b1"
                            },
                            new Connection
                            {
                                ConnectionId = 4,
                                UserId1 = "1950ebbc-a093-422b-af5f-22521e88f45f",
                                UserId2 = "3826d32d-8dc1-46ae-b703-cd7653700ca3"
                            },
                            new Connection
                            {
                                ConnectionId = 5,
                                UserId1 = "5a082b37-3f47-423a-ba4b-00add48d25be",
                                UserId2 = "8222f166-68df-4397-ad33-89d00f86a3f5"
                            },
                            new Connection
                            {
                                ConnectionId = 6,
                                UserId1 = "f4b049d4-d1ca-4bc4-bcb7-79c4f2b5f8d0",
                                UserId2 = "5a082b37-3f47-423a-ba4b-00add48d25be"
                            },
                            new Connection
                            {
                                ConnectionId = 7,
                                UserId1 = "518ae485-ef25-4aee-bbec-f7f1bfff51b1",
                                UserId2 = "3826d32d-8dc1-46ae-b703-cd7653700ca3"
                            },
                            new Connection
                            {
                                ConnectionId = 8,
                                UserId1 = "805a3c1e-9bf8-4caf-8530-174e71d44637",
                                UserId2 = "f4b049d4-d1ca-4bc4-bcb7-79c4f2b5f8d0"
                            }
                        );
                    }

                    context.SaveChanges();
                    context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT dbo.Connection OFF;");

                    transaction.Commit();
                }
            }
        }
    }
}
