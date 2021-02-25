using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace StepUpToPlants.Models
{
    public class IndexViewModel
    {
        private List<PlantSheetModel> _plantSheet;
        
        public IndexViewModel()
        {   
            
            //Section Fiches
            _plantSheet = new List<PlantSheetModel>();
            _plantSheet.Add(new PlantSheetModel()
            {
                Type = "Racine",
                ComName = "Ail",
                ScienName = "Allium sativum",
                NeedLight = "soleil.jpg",
                Description = "Famille des liliacées. Elle est composée d’une tige creuse et assez grande, de nombreuses feuilles engainant le bas de cette tige, de fleurs blanches ou rosées groupées en ombelles, et d’un bulbe (ou ‘’tête’’). Originaire d’Asie centrale, il s’agit d’une plante potagère très facile à cultiver, qui pousse et qui s’adapte à des climats très différents, aussi bien tempéré que chaud. C’est la raison pour laquelle on en retrouve des plantations sur tout le globe. Il a une odeur forte et un goût âcre.",
                AvoidPlant = "Fèves, Haricots, Pois",
                AvHeight = "40 à 60 cm",
                PlantTime = "Début Printemps, Milieu Automne",
                HarvTime = "4 ou 8 mois",
                BigPicture = "ail.jpg",
                Heat = "soleil.jpg"
            });

            _plantSheet.Add(new PlantSheetModel()
            {
                Type = "Feuille",
                ComName = "Aneth",
                ScienName = "Anethum graveolens",
                NeedLight = "soleilorange.jpg",
                Description = "Famille des apiacées. On l'appelle encore fenouil bâtard, dill ou faux anis. Sa grande tige vert bleuté porte de longues feuilles filiformes en forme de rameaux. Ses fleurs, jaune pâle, se présentent en ombelles. Ce sont elles qui contiennent les graines, fruits d'automne de la plante. Ces graines, ovales et brun clair, rappellent les graines de carvi. Originaire d’Asie mineure, l'aneth pousse au bord des chemins ou sur les terrains vagues ; il aime les sols secs et pierreux.Elle possède des vertus digestives et stimulantes.",
                AvoidPlant = "Carottes",
                AvHeight = "40 cm à 1 m",
                PlantTime = "D'avril jusqu'au début de l'été",
                HarvTime = "6 mois",
                BigPicture = "aneth.jpg",
                Heat = "soleilorange.jpg"
            });
        }

        public List<PlantSheetModel> PlantSheet
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