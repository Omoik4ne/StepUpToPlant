using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace StepUpToPlants.Models
{
    public class IndexViewModel
    {
        private PlantSheet _plantSheet;
        public IndexViewModel()
        {
            _plantSheet = new PlantSheet();
            _plantSheet.Type = "Racine";
            _plantSheet.ComName = "Ail";
            _plantSheet.ScienName = "Allium sativum";
            _plantSheet.NeedLight = "logo1.jpg";
            _plantSheet.Description = "Famille des liliacées. Originaire d’Asie centrale, il s’agit d’une plante potagère très facile à cultiver, qui pousse et qui s’adapte à des climats très différents, aussi bien tempéré que chaud. C’est la raison pour laquelle on en retrouve des plantations sur tout le globe. Il a une odeur forte et un goût âcre.";
            _plantSheet.AvoidPlant = "Fèves, Haricots, Pois";
            _plantSheet.AvHeight = "40 à 60 cm";
            _plantSheet.PlantTime = "Début Printemps, Milieu Automne";
            _plantSheet.HarvTime = "4 ou 8 mois";
            _plantSheet.BigPicture = "ail.jpg";
        }

        public PlantSheet PlantSheet
        {
            get
            {
                return _plantSheet;
            }

            set
            {
                _plantSheet = value;
            }
        }
    } 
}