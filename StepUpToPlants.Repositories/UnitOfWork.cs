//using NetFlask.DAL.Repositories;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;

//namespace NetFlask.Repositories
//{
//    //alias du datacontext
//    public class UnitOfWork
//    {
//        IConcreteRepository<SheetEntity> _sheetRepo;

//        public UnitOfWork(string connectionString)
//        {
//            _sheetRepo = new SheetRepository(connectionString);
//        }

//            public Sheet GetSheet()
//            {
//                //Récupération de mon entity
//                SheetEntity sheetFromDB = _sheetRepo.GetOne(18);
              
//                //Mapping de l'entity vers le model
//                Sheet sheetForController = new Sheet();
//                sheetForController.Title = sheetFromDB.Name; //"Frozen II";
//                sheetForController.Age = "All Age";
//                sheetForController.Directors = directors;
//                sheetForController.Rating = sheetFromDB.Rating; //((RatingRepository)_ratingRepository).GetByMovie(movieFromDB.IdMovie).Average(m => m.Score);
//                sheetForController.CriticsRating = sheetFromDB.CriticsRating;
//                sheetForController.Genres = genres;
//                sheetForController.Release = sheetFromDB.ReleaseDate.Value; //new DateTime(2019, 11, 22);
//                sheetForController.Description = sheetFromDB.Summary; //"Anna, Elsa, Kristoff, Olaf and Sven leave Arendelle to travel to an ancient, autumn-bound forest of an enchanted land. They set out to find the origin of Elsa's powers in order to save their kingdom";
//                sheetForController.VideoLink = sheetFromDB.Trailer; //"#";
//                sheetForController.BigPicture = "https://www.themoviedb.org/t/p/original" + sheetFromDB.Picture; //"FrozenII.jpg";

//                return sheetForController;
//            }
//        }
//    }
//}