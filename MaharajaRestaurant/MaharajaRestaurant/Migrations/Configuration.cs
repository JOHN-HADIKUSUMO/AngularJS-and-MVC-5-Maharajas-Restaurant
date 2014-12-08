namespace MaharajaRestaurant.Migrations
{
    using System;
    using System.Web;
    using System.Security.Cryptography;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using MaharajaRestaurant.Models;
    using MaharajaRestaurant.DAL;

    internal sealed class Configuration : DbMigrationsConfiguration<MaharajaRestaurant.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MaharajaRestaurant.Models.ApplicationDbContext context)
        {
            if (!context.Roles.Any(r => r.Name.ToUpper() == "ADMINISTRATOR"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "ADMINISTRATOR" };
                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name.ToUpper() == "CUSTOMER"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "CUSTOMER" };
                manager.Create(role);
            }


            if (!context.Users.Any(u => u.UserName == "administrator"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "administrator" };

                manager.Create(user, "asdQWE!@#");
                manager.AddToRole(user.Id, "ADMINISTRATOR");
            }

            if (!context.Users.Any(u => u.UserName == "happycustomer"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "happycustomer" };

                manager.Create(user, "asdQWE!@#");
                manager.AddToRole(user.Id, "CUSTOMER");
            }

            if (!context.Menus.Any(u => u.Type == DAL.MenusType.Entrees))
            {
                /* Entrees starts here */
                Menu menu0 = new Menu();
                menu0.Name = "VEGETABLE SAMOSA";
                menu0.Description = "Short pastry pockets filled with mashed potato, spices, peas and served with mint sauce.";
                menu0.Type = MenusType.Entrees;
                menu0.Price = 2.70;
                menu0.WordAfterPrice = "(3pcs)";
                context.Menus.AddOrUpdate(menu0);

                PhotoMenu photo0_0 = new PhotoMenu();
                photo0_0.MenuID = 1;
                photo0_0.Filename = "VEGETABLE_SAMOSA_0.png";
                photo0_0.GUIDFilename = "C2B6BAAA-0CF7-4BA8-BB29-FEF6FCA8FCFB.png";

                PhotoMenu photo0_1 = new PhotoMenu();
                photo0_1.MenuID = 1;
                photo0_1.Filename = "VEGETABLE_SAMOSA_1.png";
                photo0_1.GUIDFilename = "756A933D-08D0-4201-A8B4-EFB6F42A895F.png";

                PhotoMenu photo0_2 = new PhotoMenu();
                photo0_2.MenuID = 1;
                photo0_2.Filename = "VEGETABLE_SAMOSA_2.png";
                photo0_2.GUIDFilename = "D737A4D7-B162-4C16-80BC-AF58223327CF.png";

                Menu menu1 = new Menu();
                menu1.Name = "ONION PAKORA";
                menu1.Description = "Slices of onions with herbs, lentils, spices blended in chick pea flour and served with mint sauce.";
                menu1.Type = MenusType.Entrees;
                menu1.Price = 1.20;
                menu1.WordAfterPrice = "(per plate)";
                context.Menus.AddOrUpdate(menu1);

                PhotoMenu photo1_0 = new PhotoMenu();
                photo1_0.MenuID = 2;
                photo1_0.Filename = "ONION PAKORA_0.png";
                photo1_0.GUIDFilename = "795123A9-E5D6-4D58-B304-33110D065A0D.png";

                PhotoMenu photo1_1 = new PhotoMenu();
                photo1_1.MenuID = 2;
                photo1_1.Filename = "ONION PAKORA_1.png";
                photo1_1.GUIDFilename = "D04AB26D-9CB9-47A0-A9AC-C876F6F2E868.png";

                Menu menu2 = new Menu();
                menu2.Name = "CHICKEN TIKKA";
                menu2.Description = "Chicken thigh fillets marinated in yoghurt, spices, cooked in Tandoor and served with mint sauce.";
                menu2.Type = MenusType.Entrees;
                menu2.Price = 2.50;
                menu2.WordAfterPrice = "(small plate)";
                context.Menus.AddOrUpdate(menu2);

                PhotoMenu photo2_0 = new PhotoMenu();
                photo2_0.MenuID = 3;
                photo2_0.Filename = "CHICKEN TIKKA_0.png";
                photo2_0.GUIDFilename = "17950D52-F989-40B9-8B19-DFA0FA45AB7F.png";

                PhotoMenu photo2_1 = new PhotoMenu();
                photo2_1.MenuID = 3;
                photo2_1.Filename = "CHICKEN TIKKA_0.png";
                photo2_1.GUIDFilename = "E52D9F9F-30E0-49F4-BD4A-F9EEF7C01466.png";
            }

            if (!context.Menus.Any(u => u.Type == DAL.MenusType.Main_Course))
            {
                Menu menu3 = new Menu();
                menu3.Name = "CHICKEN BUTTER MASALA";
                menu3.Description = "Boneless tandoori chicken cooked in onions, tomato, ginger, fresh coriander and finished with cream.";
                menu3.Type = MenusType.Main_Course;
                menu3.Price = 12.90;
                menu3.WordAfterPrice = "/plate";
                context.Menus.AddOrUpdate(menu3);

                Menu menu4 = new Menu();
                menu4.Name = "ROGAN JOSH CHICKEN";
                menu4.Description = "Lamb, chicken or beef pieces cooked in yogurt, tomato and spices - mild, medium or hot.";
                menu4.Type = MenusType.Main_Course;
                menu4.Price = 12.90;
                menu4.WordAfterPrice = "/plate";
                context.Menus.AddOrUpdate(menu4);

                PhotoMenu photo4_0 = new PhotoMenu();
                photo4_0.MenuID = 5;
                photo4_0.Filename = "CHICKEN TIKKA_0.png";
                photo4_0.GUIDFilename = "E52D9F9F-30E0-49F4-BD4A-F9EEF7C01466.png";

                Menu menu5 = new Menu();
                menu5.Name = "CHICKEN KORMA";
                menu5.Description = "Boneless pieces of chicken cooked in cream and yoghurt and finished with cashew nut paste - mild.";
                menu5.Type = MenusType.Main_Course;
                menu5.Price = 14.90;
                menu5.WordAfterPrice = "/plate";
                context.Menus.AddOrUpdate(menu5);


                Menu menu6 = new Menu();
                menu6.Name = "CHICKEN DOPIAZA";
                menu6.Description = "Tender chicken pieces cooked with whole dried red chillies, sauteed onion, ginger and fresh coriander - medium hot.";
                menu6.Type = MenusType.Main_Course;
                menu6.Price = 14.90;
                menu6.WordAfterPrice = "/plate";
                context.Menus.AddOrUpdate(menu6);


                Menu menu7 = new Menu();
                menu7.Name = "BHOONA GOSHT (Lamb / Beef)";
                menu7.Description = "Lamb / beef marinated with garlic, ginger, capsicum and tomato, cooked in a hot pan to seal in the natural juices.- Med. Hot";
                menu7.Type = MenusType.Main_Course;
                menu7.Price = 16.90;
                menu7.WordAfterPrice = "/plate";
                context.Menus.AddOrUpdate(menu7);


                Menu menu8 = new Menu();
                menu8.Name = "ROCKLING TIKKA";
                menu8.Description = "Succulent cubes of rockling with cream, yoghurt, lemon juice and chef’s selected spices, cooked in the tandoor.";
                menu8.Type = MenusType.Main_Course;
                menu8.Price = 17.50;
                menu8.WordAfterPrice = "/plate";
                context.Menus.AddOrUpdate(menu8);


                Menu menu9 = new Menu();
                menu9.Name = "BENGAL FISH CURRY";
                menu9.Description = "Diced cubes of rockling cooked in a traditional Bengali style - Med.";
                menu9.Type = MenusType.Main_Course;
                menu9.Price = 17.90;
                menu9.WordAfterPrice = "/plate";
                context.Menus.AddOrUpdate(menu9);


                Menu menu10 = new Menu();
                menu10.Name = "CRAB MASALA CURRY";
                menu10.Description = "Crab meat lightly sauteed, tempered with mustard seeds, cooked with chopped onion and tomato, simmered in coconut milk with spices, garnished with shredded coconut and curry leaves.- Med / Hot.";
                menu10.Type = MenusType.Main_Course;
                menu10.Price = 19.90;
                menu10.WordAfterPrice = "/plate";
                context.Menus.AddOrUpdate(menu10);
            }


            if (!context.Menus.Any(u => u.Type == DAL.MenusType.Side_Dishes))
            {
                Menu menu11 = new Menu();
                menu11.Name = "Mango Chutney";
                menu11.Description = "";
                menu11.Type = MenusType.Side_Dishes;
                menu11.Price = 3.50;
                menu11.WordAfterPrice = "(small bowl)";
                context.Menus.AddOrUpdate(menu11);

                Menu menu12 = new Menu();
                menu12.Name = "Mixed Pickles";
                menu12.Description = "";
                menu12.Type = MenusType.Side_Dishes;
                menu12.Price = 3.50;
                menu12.WordAfterPrice = "(small bowl)";
                context.Menus.AddOrUpdate(menu12);

            }


            if (!context.Menus.Any(u => u.Type == DAL.MenusType.Breads_and_Rice))
            {
                Menu menu13 = new Menu();
                menu13.Name = "ZAFFARANI PULAO";
                menu13.Description = "Basmati rice, tempered with cumin seeds in clarified butter and laced with saffron.";
                menu13.Type = MenusType.Breads_and_Rice;
                menu13.Price = 5.00;
                menu13.WordAfterPrice = "/plate";
                context.Menus.AddOrUpdate(menu13);

                Menu menu14 = new Menu();
                menu14.Name = "HYDERABADI BIRIYANI(LAMB/ CHICKEN)";
                menu14.Description = "Basmati rice cooked with diced lamb or chicken,Stock and specially prepared masala, garnished with fried onion.";
                menu14.Type = MenusType.Breads_and_Rice;
                menu14.Price = 11.50;
                menu14.WordAfterPrice = "/plate";
                context.Menus.AddOrUpdate(menu14);

                Menu menu15 = new Menu();
                menu15.Name = "VEGETABLE BIRIYANI";
                menu15.Description = "Selection of seasonal vegetables cooked in a sealed pot with basmati rice and herbs.";
                menu15.Type = MenusType.Breads_and_Rice;
                menu15.Price = 11.50;
                menu15.WordAfterPrice = "/plate";
                context.Menus.AddOrUpdate(menu15);

                Menu menu16 = new Menu();
                menu16.Name = "LONG GRAIN AROMATIC BASMATI RICE";
                menu16.Description = "";
                menu16.Type = MenusType.Breads_and_Rice;
                menu16.Price = 11.50;
                menu16.WordAfterPrice = "(small bowl)";
                context.Menus.AddOrUpdate(menu16);

                Menu menu17 = new Menu();
                menu17.Name = "NAAN";
                menu17.Description = "Plain flour bread baked in the tandoor.";
                menu17.Type = MenusType.Breads_and_Rice;
                menu17.Price = 2.30;
                menu17.WordAfterPrice = "/2pcs";
                context.Menus.AddOrUpdate(menu17);

                Menu menu18 = new Menu();
                menu18.Name = "GARLIC NAAN";
                menu18.Description = "Naan brushed with fresh garlic butter.";
                menu18.Type = MenusType.Breads_and_Rice;
                menu18.Price = 2.50;
                menu18.WordAfterPrice = "/2pcs";
                context.Menus.AddOrUpdate(menu18);

                Menu menu19 = new Menu();
                menu19.Name = "PESHAWARI NAAN";
                menu19.Description = "Naan cooked with assorted dry fruits and nuts.";
                menu19.Type = MenusType.Breads_and_Rice;
                menu19.Price = 5.00;
                menu19.WordAfterPrice = "";
                context.Menus.AddOrUpdate(menu19);

                Menu menu20 = new Menu();
                menu20.Name = "PANEER POTATO KULCHA";
                menu20.Description = "Bread stuffed with spiced paneer, potato, onion, garlic, coriander and chillies.";
                menu20.Type = MenusType.Breads_and_Rice;
                menu20.Price = 4.90;
                menu20.WordAfterPrice = "";
                context.Menus.AddOrUpdate(menu20);

                Menu menu21 = new Menu();
                menu21.Name = "KHEEMA KULCHA";
                menu21.Description = "Bread stuffed with minced lamb, spices and herbs.";
                menu21.Type = MenusType.Breads_and_Rice;
                menu21.Price = 4.00;
                menu21.WordAfterPrice = "";
                context.Menus.AddOrUpdate(menu21);

                Menu menu22 = new Menu();
                menu22.Name = "PARATHA";
                menu22.Description = "Flaky wholemeal indian bread lightly fried in butter.";
                menu22.Type = MenusType.Breads_and_Rice;
                menu22.Price = 2.30;
                menu22.WordAfterPrice = "";
                context.Menus.AddOrUpdate(menu22);

                Menu menu23 = new Menu();
                menu23.Name = "ROTI";
                menu23.Description = "Stone ground wholemeal indian bread baked in the tandoor.";
                menu23.Type = MenusType.Breads_and_Rice;
                menu23.Price = 2.50;
                menu23.WordAfterPrice = "";
                context.Menus.AddOrUpdate(menu23);
            }

            if (!context.Menus.Any(u => u.Type == DAL.MenusType.Desserts))
            {
                Menu menu24 = new Menu();
                menu24.Name = "MANGO / PISTA KULFI";
                menu24.Description = "Special indian ice cream with saffron, cardamom powder made with mango / pistachio nuts.";
                menu24.Type = MenusType.Breads_and_Rice;
                menu24.Price = 4.90;
                menu24.WordAfterPrice = "";
                context.Menus.AddOrUpdate(menu24);

                Menu menu25 = new Menu();
                menu25.Name = "GULAB JAMUN (2 PIECES)";
                menu25.Description = "Cottage cheese balls fried in ghee, soaked in sugar syrup.";
                menu25.Type = MenusType.Breads_and_Rice;
                menu25.Price = 4.90;
                menu25.WordAfterPrice = "";
                context.Menus.AddOrUpdate(menu25);

            }

            if (!context.Menus.Any(u => u.Type == DAL.MenusType.Drinks))
            {
                Menu menu26 = new Menu();
                menu26.Name = "LASSI Sweetened yoghurt drink";
                menu26.Description = "";
                menu26.Type = MenusType.Drinks;
                menu26.Price = 4.50;
                menu26.WordAfterPrice = "";
                context.Menus.AddOrUpdate(menu26);

                Menu menu27 = new Menu();
                menu27.Name = "MANGO LASSI";
                menu27.Description = "Yoghurt drink made with mango pulp.";
                menu27.Type = MenusType.Drinks;
                menu27.Price = 5.50;
                menu27.WordAfterPrice = "";
                context.Menus.AddOrUpdate(menu27);

            }
        }
    }
}
