//using StepUpToPlants.DAL.Repositories;
//using StepUpToPlants.Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace StepUpToPlants.Repositories
//{
//    public class SheetRepository : BaseRepository<SheetEntity>, IConcreteRepository<SheetEntity>
//    {
//        public SheetRepository(string Cnstr) : base(Cnstr)
//        {

//        }

//        public List<SheetEntity> GetByName(int idPlant)
//        {
//            string requete = @"SELECT  IdPlant, IdUser, Score, DateRating
//                                FROM
//                                Rating WHERE IdMovie=" + idPlant;
//            return base.Get(requete);
//        }

//        public List<SheetEntity> Get()
//        {
//            throw new NotImplementedException();
//        }

//        public SheetEntity GetOne(int PK)
//        {
//            throw new NotImplementedException();
//        }

//        public bool Insert(SheetEntity toInsert)
//        {
//            throw new NotImplementedException();
//        }

//        public bool Update(SheetEntity toUpdate)
//        {
//            throw new NotImplementedException();
//        }

//        public bool Delete(SheetEntity toDelete)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
