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

    internal sealed class Configuration : DbMigrationsConfiguration<MaharajaRestaurant.DAL.MaharajasDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MaharajaRestaurant.DAL.MaharajasDbContext context)
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
                var user = new ApplicationUser { UserName = "administrator",Email = "administrator@maharajasrestaurant.com.au" };

                manager.Create(user, "asdQWE!@#");
                manager.AddToRole(user.Id, "ADMINISTRATOR");
            }

            if (!context.Users.Any(u => u.UserName == "happycustomer"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser { UserName = "happycustomer", Email = "happycustomer@maharajasrestaurant.com.au" };

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
                context.SaveChanges();

                PhotoMenu photo0_0 = new PhotoMenu();
                photo0_0.MenuID = 1;
                photo0_0.Filename = "VEGETABLE_SAMOSA_0.png";
                photo0_0.GUIDFilename = "C2B6BAAA-0CF7-4BA8-BB29-FEF6FCA8FCFB.png";
                context.PhotoMenus.AddOrUpdate(photo0_0);
                context.SaveChanges();

                PhotoMenu photo0_1 = new PhotoMenu();
                photo0_1.MenuID = 1;
                photo0_1.Filename = "VEGETABLE_SAMOSA_1.png";
                photo0_1.GUIDFilename = "756A933D-08D0-4201-A8B4-EFB6F42A895F.png";
                context.PhotoMenus.AddOrUpdate(photo0_1);
                context.SaveChanges();

                PhotoMenu photo0_2 = new PhotoMenu();
                photo0_2.MenuID = 1;
                photo0_2.Filename = "VEGETABLE_SAMOSA_2.png";
                photo0_2.GUIDFilename = "D737A4D7-B162-4C16-80BC-AF58223327CF.png";
                context.PhotoMenus.AddOrUpdate(photo0_2);
                context.SaveChanges();

                Menu menu1 = new Menu();
                menu1.Name = "ONION PAKORA";
                menu1.Description = "Slices of onions with herbs, lentils, spices blended in chick pea flour and served with mint sauce.";
                menu1.Type = MenusType.Entrees;
                menu1.Price = 1.20;
                menu1.WordAfterPrice = "(per plate)";
                context.Menus.AddOrUpdate(menu1);
                context.SaveChanges();

                PhotoMenu photo1_0 = new PhotoMenu();
                photo1_0.MenuID = 2;
                photo1_0.Filename = "ONION PAKORA_0.png";
                photo1_0.GUIDFilename = "795123A9-E5D6-4D58-B304-33110D065A0D.png";
                context.PhotoMenus.AddOrUpdate(photo1_0);
                context.SaveChanges();

                PhotoMenu photo1_1 = new PhotoMenu();
                photo1_1.MenuID = 2;
                photo1_1.Filename = "ONION PAKORA_1.png";
                photo1_1.GUIDFilename = "D04AB26D-9CB9-47A0-A9AC-C876F6F2E868.png";
                context.PhotoMenus.AddOrUpdate(photo1_1);
                context.SaveChanges();

                Menu menu2 = new Menu();
                menu2.Name = "CHICKEN TIKKA";
                menu2.Description = "Chicken thigh fillets marinated in yoghurt, spices, cooked in Tandoor and served with mint sauce.";
                menu2.Type = MenusType.Entrees;
                menu2.Price = 2.50;
                menu2.WordAfterPrice = "(small plate)";
                context.Menus.AddOrUpdate(menu2);
                context.SaveChanges();

                PhotoMenu photo2_0 = new PhotoMenu();
                photo2_0.MenuID = 3;
                photo2_0.Filename = "CHICKEN TIKKA_0.png";
                photo2_0.GUIDFilename = "17950D52-F989-40B9-8B19-DFA0FA45AB7F.png";
                context.PhotoMenus.AddOrUpdate(photo2_0);
                context.SaveChanges();

                PhotoMenu photo2_1 = new PhotoMenu();
                photo2_1.MenuID = 3;
                photo2_1.Filename = "CHICKEN TIKKA_0.png";
                photo2_1.GUIDFilename = "E52D9F9F-30E0-49F4-BD4A-F9EEF7C01466.png";
                context.PhotoMenus.AddOrUpdate(photo2_1);
                context.SaveChanges();
            }

            /* Main Course starts here */
            if (!context.Menus.Any(u => u.Type == DAL.MenusType.Main_Course))
            {
                Menu menu3 = new Menu();
                menu3.Name = "CHICKEN BUTTER MASALA";
                menu3.Description = "Boneless tandoori chicken cooked in onions, tomato, ginger, fresh coriander and finished with cream.";
                menu3.Type = MenusType.Main_Course;
                menu3.Price = 12.90;
                menu3.WordAfterPrice = "/plate";
                context.Menus.AddOrUpdate(menu3);
                context.SaveChanges();

                PhotoMenu photo3_0 = new PhotoMenu();
                photo3_0.MenuID = 4;
                photo3_0.Filename = "CHICKEN BUTTER MASALA_0.png";
                photo3_0.GUIDFilename = "46B656A4-8353-41AE-85F2-1DF87A095639.png";
                context.PhotoMenus.AddOrUpdate(photo3_0);
                context.SaveChanges();

                PhotoMenu photo3_1 = new PhotoMenu();
                photo3_1.MenuID = 4;
                photo3_1.Filename = "CHICKEN BUTTER MASALA_1.png";
                photo3_1.GUIDFilename = "EE12E891-1597-427E-A9B2-4106B14EACDB.png";
                context.PhotoMenus.AddOrUpdate(photo3_1);
                context.SaveChanges();

                PhotoMenu photo3_2 = new PhotoMenu();
                photo3_2.MenuID = 4;
                photo3_2.Filename = "CHICKEN BUTTER MASALA_2.png";
                photo3_2.GUIDFilename = "454273D0-D239-46A7-AC90-DC2AFDCF0AA6.png";
                context.PhotoMenus.AddOrUpdate(photo3_2);
                context.SaveChanges();

                Menu menu4 = new Menu();
                menu4.Name = "ROGAN JOSH CHICKEN";
                menu4.Description = "Lamb, chicken or beef pieces cooked in yogurt, tomato and spices - mild, medium or hot.";
                menu4.Type = MenusType.Main_Course;
                menu4.Price = 12.90;
                menu4.WordAfterPrice = "/plate";
                context.Menus.AddOrUpdate(menu4);
                context.SaveChanges();

                PhotoMenu photo4_0 = new PhotoMenu();
                photo4_0.MenuID = 5;
                photo4_0.Filename = "CHICKEN TIKKA_0.png";
                photo4_0.GUIDFilename = "E52D9F9F-30E0-49F4-BD4A-F9EEF7C01466.png";
                context.PhotoMenus.AddOrUpdate(photo4_0);
                context.SaveChanges();

                Menu menu5 = new Menu();
                menu5.Name = "CHICKEN KORMA";
                menu5.Description = "Boneless pieces of chicken cooked in cream and yoghurt and finished with cashew nut paste - mild.";
                menu5.Type = MenusType.Main_Course;
                menu5.Price = 14.90;
                menu5.WordAfterPrice = "/plate";
                context.Menus.AddOrUpdate(menu5);
                context.SaveChanges();

                PhotoMenu photo5_0 = new PhotoMenu();
                photo5_0.MenuID = 6;
                photo5_0.Filename = "CHICKEN_KORMA.png";
                photo5_0.GUIDFilename = "9CF3E910-7ACE-4E58-9C5B-121127DEB7DD.png";
                context.PhotoMenus.AddOrUpdate(photo5_0);
                context.SaveChanges();

                PhotoMenu photo5_1 = new PhotoMenu();
                photo5_1.MenuID = 6;
                photo5_1.Filename = "CHICKEN_KORMA.png";
                photo5_1.GUIDFilename = "AF268FEC-40A8-4F07-82ED-2A16569B031D.png";
                context.PhotoMenus.AddOrUpdate(photo5_1);
                context.SaveChanges();

                Menu menu6 = new Menu();
                menu6.Name = "CHICKEN DOPIAZA";
                menu6.Description = "Tender chicken pieces cooked with whole dried red chillies, sauteed onion, ginger and fresh coriander - medium hot.";
                menu6.Type = MenusType.Main_Course;
                menu6.Price = 14.90;
                menu6.WordAfterPrice = "/plate";
                context.Menus.AddOrUpdate(menu6);
                context.SaveChanges();

                PhotoMenu photo6_0 = new PhotoMenu();
                photo6_0.MenuID = 7;
                photo6_0.Filename = "CHICKEN_DOPIAZA.png";
                photo6_0.GUIDFilename = "3B2FA8B0-EBC6-4CB8-90EC-15A43F740AC4.png";
                context.PhotoMenus.AddOrUpdate(photo6_0);
                context.SaveChanges();

                PhotoMenu photo6_1 = new PhotoMenu();
                photo6_1.MenuID = 7;
                photo6_1.Filename = "CHICKEN_DOPIAZA.png";
                photo6_1.GUIDFilename = "CB9D3887-A081-403D-AD1E-AB729503C9CB.png";
                context.PhotoMenus.AddOrUpdate(photo6_1);
                context.SaveChanges();

                PhotoMenu photo6_2 = new PhotoMenu();
                photo6_2.MenuID = 7;
                photo6_2.Filename = "CHICKEN_DOPIAZA.png";
                photo6_2.GUIDFilename = "FBFE59B2-258B-490F-A7F3-A10055E1CE32.png";
                context.PhotoMenus.AddOrUpdate(photo6_2);
                context.SaveChanges();

                PhotoMenu photo6_3 = new PhotoMenu();
                photo6_3.MenuID = 7;
                photo6_3.Filename = "CHICKEN_DOPIAZA.png";
                photo6_3.GUIDFilename = "A2796DAD-35AE-4040-8E58-1F094154A81F.png";
                context.PhotoMenus.AddOrUpdate(photo6_3);
                context.SaveChanges();

                PhotoMenu photo6_4 = new PhotoMenu();
                photo6_4.MenuID = 7;
                photo6_4.Filename = "CHICKEN_DOPIAZA.png";
                photo6_4.GUIDFilename = "035BAE4C-2F87-48E5-92B3-8A8D1002360C.png";
                context.PhotoMenus.AddOrUpdate(photo6_4);
                context.SaveChanges();

                Menu menu7 = new Menu();
                menu7.Name = "BHOONA GOSHT (Lamb / Beef)";
                menu7.Description = "Lamb / beef marinated with garlic, ginger, capsicum and tomato, cooked in a hot pan to seal in the natural juices.- Med. Hot";
                menu7.Type = MenusType.Main_Course;
                menu7.Price = 16.90;
                menu7.WordAfterPrice = "/plate";
                context.Menus.AddOrUpdate(menu7);
                context.SaveChanges();

                PhotoMenu photo7_0 = new PhotoMenu();
                photo7_0.MenuID = 8;
                photo7_0.Filename = "BHOONA_GOSHT.png";
                photo7_0.GUIDFilename = "C9389E29-791C-4D56-9430-68B1B4DA99D0.png";
                context.PhotoMenus.AddOrUpdate(photo7_0);
                context.SaveChanges();

                Menu menu8 = new Menu();
                menu8.Name = "ROCKLING TIKKA";
                menu8.Description = "Succulent cubes of rockling with cream, yoghurt, lemon juice and chef’s selected spices, cooked in the tandoor.";
                menu8.Type = MenusType.Main_Course;
                menu8.Price = 17.50;
                menu8.WordAfterPrice = "/plate";
                context.Menus.AddOrUpdate(menu8);
                context.SaveChanges();

                PhotoMenu photo8_0 = new PhotoMenu();
                photo8_0.MenuID = 9;
                photo8_0.Filename = "ROCKLING_TIKKA.png";
                photo8_0.GUIDFilename = "29512990-D9BD-4613-9E52-8FF50AF096A5.png";
                context.PhotoMenus.AddOrUpdate(photo8_0);
                context.SaveChanges();

                Menu menu9 = new Menu();
                menu9.Name = "BENGAL FISH CURRY";
                menu9.Description = "Diced cubes of rockling cooked in a traditional Bengali style - Med.";
                menu9.Type = MenusType.Main_Course;
                menu9.Price = 17.90;
                menu9.WordAfterPrice = "/plate";
                context.Menus.AddOrUpdate(menu9);
                context.SaveChanges();

                PhotoMenu photo9_0 = new PhotoMenu();
                photo9_0.MenuID = 10;
                photo9_0.Filename = "BENGAL_FISH_CURRY.png";
                photo9_0.GUIDFilename = "35DAC79C-6322-4317-ABD2-50A7D18AED33.png";
                context.PhotoMenus.AddOrUpdate(photo9_0);
                context.SaveChanges();

                PhotoMenu photo9_1 = new PhotoMenu();
                photo9_1.MenuID = 10;
                photo9_1.Filename = "BENGAL_FISH_CURRY.png";
                photo9_1.GUIDFilename = "1472844E-B704-4659-8311-7C01498F3D42.png";
                context.PhotoMenus.AddOrUpdate(photo9_1);
                context.SaveChanges();

                PhotoMenu photo9_2 = new PhotoMenu();
                photo9_2.MenuID = 10;
                photo9_2.Filename = "BENGAL_FISH_CURRY.png";
                photo9_2.GUIDFilename = "32D098D5-E18D-44E0-B896-62C3860F4742.png";
                context.PhotoMenus.AddOrUpdate(photo9_2);
                context.SaveChanges();

                Menu menu10 = new Menu();
                menu10.Name = "CRAB MASALA CURRY";
                menu10.Description = "Crab meat lightly sauteed, tempered with mustard seeds, cooked with chopped onion and tomato, simmered in coconut milk with spices, garnished with shredded coconut and curry leaves.- Med / Hot.";
                menu10.Type = MenusType.Main_Course;
                menu10.Price = 19.90;
                menu10.WordAfterPrice = "/plate";
                context.Menus.AddOrUpdate(menu10);
                context.SaveChanges();
            }

            /* Side Dishes starts here */
            if (!context.Menus.Any(u => u.Type == DAL.MenusType.Side_Dishes))
            {
                Menu menu11 = new Menu();
                menu11.Name = "Mango Chutney";
                menu11.Description = "";
                menu11.Type = MenusType.Side_Dishes;
                menu11.Price = 3.50;
                menu11.WordAfterPrice = "(small bowl)";
                context.Menus.AddOrUpdate(menu11);
                context.SaveChanges();

                PhotoMenu photo11_0 = new PhotoMenu();
                photo11_0.MenuID = 12;
                photo11_0.Filename = "Mango_Chutney.png";
                photo11_0.GUIDFilename = "E4CEF3A9-5C47-42BC-B5F4-50B3306D674F.png";
                context.PhotoMenus.AddOrUpdate(photo11_0);
                context.SaveChanges();

                Menu menu12 = new Menu();
                menu12.Name = "Mixed Pickles";
                menu12.Description = "";
                menu12.Type = MenusType.Side_Dishes;
                menu12.Price = 3.50;
                menu12.WordAfterPrice = "(small bowl)";
                context.Menus.AddOrUpdate(menu12);
                context.SaveChanges();

                PhotoMenu photo12_0 = new PhotoMenu();
                photo12_0.MenuID = 13;
                photo12_0.Filename = "Mixed_Pickles.png";
                photo12_0.GUIDFilename = "EE3484B8-38C7-4872-97D6-6E8A3EA7596D.png";
                context.PhotoMenus.AddOrUpdate(photo12_0);
                context.SaveChanges();

                PhotoMenu photo12_1 = new PhotoMenu();
                photo12_1.MenuID = 13;
                photo12_1.Filename = "Mixed_Pickles.png";
                photo12_1.GUIDFilename = "3A7D7035-BE3F-49FC-BAB2-2ED230D105EB.png";
                context.PhotoMenus.AddOrUpdate(photo12_1);
                context.SaveChanges();
            }

            /* Breads and Rice starts here */
            if (!context.Menus.Any(u => u.Type == DAL.MenusType.Breads_and_Rice))
            {
                Menu menu13 = new Menu();
                menu13.Name = "ZAFFARANI PULAO";
                menu13.Description = "Basmati rice, tempered with cumin seeds in clarified butter and laced with saffron.";
                menu13.Type = MenusType.Breads_and_Rice;
                menu13.Price = 5.00;
                menu13.WordAfterPrice = "/plate";
                context.Menus.AddOrUpdate(menu13);
                context.SaveChanges();

                PhotoMenu photo13_0 = new PhotoMenu();
                photo13_0.MenuID = 14;
                photo13_0.Filename = "ZAFFARANI_PULAO.png";
                photo13_0.GUIDFilename = "6A9DB57D-98C6-4542-9CF1-58414E6AE2F4.png";
                context.PhotoMenus.AddOrUpdate(photo13_0);
                context.SaveChanges();

                Menu menu14 = new Menu();
                menu14.Name = "HYDERABADI BIRIYANI(LAMB/ CHICKEN)";
                menu14.Description = "Basmati rice cooked with diced lamb or chicken,Stock and specially prepared masala, garnished with fried onion.";
                menu14.Type = MenusType.Breads_and_Rice;
                menu14.Price = 11.50;
                menu14.WordAfterPrice = "/plate";
                context.Menus.AddOrUpdate(menu14);
                context.SaveChanges();

                Menu menu15 = new Menu();
                menu15.Name = "VEGETABLE BIRIYANI";
                menu15.Description = "Selection of seasonal vegetables cooked in a sealed pot with basmati rice and herbs.";
                menu15.Type = MenusType.Breads_and_Rice;
                menu15.Price = 11.50;
                menu15.WordAfterPrice = "/plate";
                context.Menus.AddOrUpdate(menu15);
                context.SaveChanges();

                PhotoMenu photo15_0 = new PhotoMenu();
                photo15_0.MenuID = 16;
                photo15_0.Filename = "HYDERABADI_BIRIYANI.png";
                photo15_0.GUIDFilename = "38DE39D7-DCDD-4695-80F6-0396D8B6B9FD.png";
                context.PhotoMenus.AddOrUpdate(photo15_0);
                context.SaveChanges();

                Menu menu16 = new Menu();
                menu16.Name = "LONG GRAIN AROMATIC BASMATI RICE";
                menu16.Description = "";
                menu16.Type = MenusType.Breads_and_Rice;
                menu16.Price = 11.50;
                menu16.WordAfterPrice = "(small bowl)";
                context.Menus.AddOrUpdate(menu16);
                context.SaveChanges();

                PhotoMenu photo16_0 = new PhotoMenu();
                photo16_0.MenuID = 17;
                photo16_0.Filename = "LONG_GRAIN_AROMATIC_BASMATI_RICE.png";
                photo16_0.GUIDFilename = "984547A2-8357-42EA-A730-A927E463DA66.png";
                context.PhotoMenus.AddOrUpdate(photo16_0);
                context.SaveChanges();

                Menu menu17 = new Menu();
                menu17.Name = "NAAN";
                menu17.Description = "Plain flour bread baked in the tandoor.";
                menu17.Type = MenusType.Breads_and_Rice;
                menu17.Price = 2.30;
                menu17.WordAfterPrice = "/2pcs";
                context.Menus.AddOrUpdate(menu17);
                context.SaveChanges();

                Menu menu18 = new Menu();
                menu18.Name = "GARLIC NAAN";
                menu18.Description = "Naan brushed with fresh garlic butter.";
                menu18.Type = MenusType.Breads_and_Rice;
                menu18.Price = 2.50;
                menu18.WordAfterPrice = "/2pcs";
                context.Menus.AddOrUpdate(menu18);
                context.SaveChanges();

                PhotoMenu photo18_0 = new PhotoMenu();
                photo18_0.MenuID = 19;
                photo18_0.Filename = "LONG_GRAIN_AROMATIC_BASMATI_RICE.png";
                photo18_0.GUIDFilename = "827EDE4F-73F8-4D46-AB73-71092242A3A9.png";
                context.PhotoMenus.AddOrUpdate(photo18_0);
                context.SaveChanges();

                PhotoMenu photo18_1 = new PhotoMenu();
                photo18_1.MenuID = 19;
                photo18_1.Filename = "LONG_GRAIN_AROMATIC_BASMATI_RICE.png";
                photo18_1.GUIDFilename = "48531542-3DC3-4553-AB87-9630A320D366.png";
                context.PhotoMenus.AddOrUpdate(photo18_1);
                context.SaveChanges();

                Menu menu19 = new Menu();
                menu19.Name = "PESHAWARI NAAN";
                menu19.Description = "Naan cooked with assorted dry fruits and nuts.";
                menu19.Type = MenusType.Breads_and_Rice;
                menu19.Price = 5.00;
                menu19.WordAfterPrice = "";
                context.Menus.AddOrUpdate(menu19);
                context.SaveChanges();

                PhotoMenu photo19_0 = new PhotoMenu();
                photo19_0.MenuID = 20;
                photo19_0.Filename = "PESHAWARI_NAAN.png";
                photo19_0.GUIDFilename = "99BB525B-8C9F-450A-9001-C649526CF2D1.png";
                context.PhotoMenus.AddOrUpdate(photo19_0);
                context.SaveChanges();

                PhotoMenu photo19_1 = new PhotoMenu();
                photo19_1.MenuID = 20;
                photo19_1.Filename = "PESHAWARI_NAAN.png";
                photo19_1.GUIDFilename = "29FF8BE9-FD94-44EB-AFAD-C29B3A583404.png";
                context.PhotoMenus.AddOrUpdate(photo19_1);
                context.SaveChanges();

                Menu menu20 = new Menu();
                menu20.Name = "PANEER POTATO KULCHA";
                menu20.Description = "Bread stuffed with spiced paneer, potato, onion, garlic, coriander and chillies.";
                menu20.Type = MenusType.Breads_and_Rice;
                menu20.Price = 4.90;
                menu20.WordAfterPrice = "";
                context.Menus.AddOrUpdate(menu20);
                context.SaveChanges();

                Menu menu21 = new Menu();
                menu21.Name = "KHEEMA KULCHA";
                menu21.Description = "Bread stuffed with minced lamb, spices and herbs.";
                menu21.Type = MenusType.Breads_and_Rice;
                menu21.Price = 4.00;
                menu21.WordAfterPrice = "";
                context.Menus.AddOrUpdate(menu21);
                context.SaveChanges();

                PhotoMenu photo21_0 = new PhotoMenu();
                photo21_0.MenuID = 22;
                photo21_0.Filename = "KHEEMA_KULCHA.png";
                photo21_0.GUIDFilename = "B9C88C79-78DC-4787-85ED-238C6B945ECA.png";
                context.PhotoMenus.AddOrUpdate(photo21_0);
                context.SaveChanges();

                Menu menu22 = new Menu();
                menu22.Name = "PARATHA";
                menu22.Description = "Flaky wholemeal indian bread lightly fried in butter.";
                menu22.Type = MenusType.Breads_and_Rice;
                menu22.Price = 2.30;
                menu22.WordAfterPrice = "";
                context.Menus.AddOrUpdate(menu22);
                context.SaveChanges();

                PhotoMenu photo22_0 = new PhotoMenu();
                photo22_0.MenuID = 23;
                photo22_0.Filename = "PARATHA.png";
                photo22_0.GUIDFilename = "983B99CC-63AA-4C5C-957D-DA4B9FC27BC0.png";
                context.PhotoMenus.AddOrUpdate(photo22_0);
                context.SaveChanges();

                Menu menu23 = new Menu();
                menu23.Name = "ROTI";
                menu23.Description = "Stone ground wholemeal indian bread baked in the tandoor.";
                menu23.Type = MenusType.Breads_and_Rice;
                menu23.Price = 2.50;
                menu23.WordAfterPrice = "";
                context.Menus.AddOrUpdate(menu23);
                context.SaveChanges();

                PhotoMenu photo23_0 = new PhotoMenu();
                photo23_0.MenuID = 24;
                photo23_0.Filename = "ROTI.png";
                photo23_0.GUIDFilename = "06409BB6-B146-4D3C-A7FD-3B02584177E7.png";
                context.PhotoMenus.AddOrUpdate(photo23_0);
                context.SaveChanges();

                PhotoMenu photo23_1 = new PhotoMenu();
                photo23_1.MenuID = 24;
                photo23_1.Filename = "ROTI.png";
                photo23_1.GUIDFilename = "E7D15EBD-CF15-444D-A687-CC355BC37037.png";
                context.PhotoMenus.AddOrUpdate(photo23_1);
                context.SaveChanges();
            }

            /* Desserts starts here */
            if (!context.Menus.Any(u => u.Type == DAL.MenusType.Desserts))
            {
                Menu menu24 = new Menu();
                menu24.Name = "MANGO / PISTA KULFI";
                menu24.Description = "Special indian ice cream with saffron, cardamom powder made with mango / pistachio nuts.";
                menu24.Type = MenusType.Breads_and_Rice;
                menu24.Price = 4.90;
                menu24.WordAfterPrice = "";
                context.Menus.AddOrUpdate(menu24);
                context.SaveChanges();

                PhotoMenu photo24_0 = new PhotoMenu();
                photo24_0.MenuID = 25;
                photo24_0.Filename = "MANGO_PISTA_KULFI.png";
                photo24_0.GUIDFilename = "2F7426AC-6ABD-47D7-B1FA-EC9790DEF010.png";
                context.PhotoMenus.AddOrUpdate(photo24_0);
                context.SaveChanges();

                Menu menu25 = new Menu();
                menu25.Name = "GULAB JAMUN (2 PIECES)";
                menu25.Description = "Cottage cheese balls fried in ghee, soaked in sugar syrup.";
                menu25.Type = MenusType.Breads_and_Rice;
                menu25.Price = 4.90;
                menu25.WordAfterPrice = "";
                context.Menus.AddOrUpdate(menu25);
                context.SaveChanges();

                PhotoMenu photo25_0 = new PhotoMenu();
                photo25_0.MenuID = 26;
                photo25_0.Filename = "GULAB_JAMUN.png";
                photo25_0.GUIDFilename = "A089B00B-0BB3-4597-A78E-84970A226ADA.png";
                context.PhotoMenus.AddOrUpdate(photo25_0);
                context.SaveChanges();

                PhotoMenu photo25_1 = new PhotoMenu();
                photo25_1.MenuID = 26;
                photo25_1.Filename = "GULAB_JAMUN.png";
                photo25_1.GUIDFilename = "CCF20935-20E8-4E0A-B189-87DE6011085B.png";
                context.PhotoMenus.AddOrUpdate(photo25_1);
                context.SaveChanges();

                PhotoMenu photo25_2 = new PhotoMenu();
                photo25_2.MenuID = 26;
                photo25_2.Filename = "GULAB_JAMUN.png";
                photo25_2.GUIDFilename = "45ED9507-4D27-48AE-8B68-3F750015F4DE.png";
                context.PhotoMenus.AddOrUpdate(photo25_2);
                context.SaveChanges();

            }

            /* Drinks starts here */
            if (!context.Menus.Any(u => u.Type == DAL.MenusType.Drinks))
            {
                Menu menu26 = new Menu();
                menu26.Name = "LASSI Sweetened yoghurt drink";
                menu26.Description = "";
                menu26.Type = MenusType.Drinks;
                menu26.Price = 4.50;
                menu26.WordAfterPrice = "";
                context.Menus.AddOrUpdate(menu26);
                context.SaveChanges();

                PhotoMenu photo26_0 = new PhotoMenu();
                photo26_0.MenuID = 27;
                photo26_0.Filename = "LASSI_Sweetened_Yoghurt_Drink.png";
                photo26_0.GUIDFilename = "0340B7C7-E51A-43E6-AD0E-7982E028EF40.png";
                context.PhotoMenus.AddOrUpdate(photo26_0);
                context.SaveChanges();


                PhotoMenu photo26_1 = new PhotoMenu();
                photo26_1.MenuID = 27;
                photo26_1.Filename = "LASSI_Sweetened_Yoghurt_Drink.png";
                photo26_1.GUIDFilename = "3D1F13CF-0707-4EDF-9871-8C51BC19ADC8.png";
                context.PhotoMenus.AddOrUpdate(photo26_1);
                context.SaveChanges();

                Menu menu27 = new Menu();
                menu27.Name = "MANGO LASSI";
                menu27.Description = "Yoghurt drink made with mango pulp.";
                menu27.Type = MenusType.Drinks;
                menu27.Price = 5.50;
                menu27.WordAfterPrice = "";
                context.Menus.AddOrUpdate(menu27);
                context.SaveChanges();

                PhotoMenu photo27_0 = new PhotoMenu();
                photo27_0.MenuID = 28;
                photo27_0.Filename = "MANGO LASSI_0.png";
                photo27_0.GUIDFilename = "1C0EA585-809A-41CA-8BB2-FFAD524EFB0F.png";
                context.PhotoMenus.AddOrUpdate(photo27_0);
                context.SaveChanges();

                PhotoMenu photo27_1 = new PhotoMenu();
                photo27_1.MenuID = 28;
                photo27_1.Filename = "MANGO LASSI_0.png";
                photo27_1.GUIDFilename = "52A33270-A843-4599-B294-FF24C918EC11.png";
                context.PhotoMenus.AddOrUpdate(photo27_1);
                context.SaveChanges();

                PhotoMenu photo27_2 = new PhotoMenu();
                photo27_2.MenuID = 28;
                photo27_2.Filename = "MANGO LASSI_0.png";
                photo27_2.GUIDFilename = "667D3545-AE50-4813-B930-F825D2FEF5C4.png";
                context.PhotoMenus.AddOrUpdate(photo27_2);
                context.SaveChanges();

                PhotoMenu photo27_3 = new PhotoMenu();
                photo27_3.MenuID = 28;
                photo27_3.Filename = "MANGO LASSI_0.png";
                photo27_3.GUIDFilename = "CDC40A6D-5918-41CC-B3A6-227D7BAD9849.png";
                context.PhotoMenus.AddOrUpdate(photo27_3);
                context.SaveChanges();
            }

            /* Seeding the Reservation table */
            if(context.Reservations.Count() == 0)
            {
                Reservation reservation_0 = new Reservation();
                reservation_0.UserID = context.Users.Where(w => w.UserName.Contains("happycustomer")).FirstOrDefault().Id;
                reservation_0.PaymentMethod = 0;
                reservation_0.NumberOfPeople = "1-5";
                reservation_0.Name = "Gracias Birthday Party";
                reservation_0.Environment = 1;
                reservation_0.Date = new DateTime(2014, 12, 31, 17, 30, 0);
                reservation_0.CreatedDate = DateTime.Today;

                context.Reservations.Add(reservation_0);


                Reservation reservation_1 = new Reservation();
                reservation_1.UserID = context.Users.Where(w => w.UserName.Contains("happycustomer")).FirstOrDefault().Id;
                reservation_1.PaymentMethod = 1;
                reservation_1.NumberOfPeople = "1-5";
                reservation_1.Name = "Reno and Pete Wedding";
                reservation_1.Environment = 0;
                reservation_1.Date = new DateTime(2015, 1, 10, 10, 0, 0);
                reservation_1.CreatedDate = DateTime.Today;

                context.Reservations.Add(reservation_1);


                Reservation reservation_2 = new Reservation();
                reservation_2.UserID = context.Users.Where(w => w.UserName.Contains("happycustomer")).FirstOrDefault().Id;
                reservation_2.PaymentMethod = 2;
                reservation_2.NumberOfPeople = "5-10";
                reservation_2.Name = "Rianka Baptism";
                reservation_2.Environment = 1;
                reservation_2.Date = new DateTime(2015, 3, 18, 10, 0, 0);
                reservation_2.CreatedDate = DateTime.Today;

                context.Reservations.Add(reservation_2);

                Reservation reservation_3 = new Reservation();
                reservation_3.UserID = context.Users.Where(w => w.UserName.Contains("happycustomer")).FirstOrDefault().Id;
                reservation_3.PaymentMethod = 0;
                reservation_3.NumberOfPeople = "20-40";
                reservation_3.Name = "Martinsen Bachelor Party";
                reservation_3.Environment = 1;
                reservation_3.Date = new DateTime(2015, 2, 10, 20, 0, 0);
                reservation_3.CreatedDate = DateTime.Today;

                context.Reservations.Add(reservation_3);

                context.SaveChanges();

            }
        }

    }
}
