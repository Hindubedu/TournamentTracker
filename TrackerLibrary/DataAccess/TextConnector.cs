using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess.TextHelpers;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        //Names for the models
        private const string PrizesFile = "PrizeModels.csv";

        private const string PeopleFile = "PersonModels.csv";
        //TODO - Wire up the CreatePrize for txt files
        public PrizeModel CreatePrize(PrizeModel model)
        {            
            // Load txt file
            // Convert to list of List<PrizeModel>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            //find id (next in list)
            int currentId = 1;

            if (prizes.Count>0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;

            }
            model.Id=currentId;

            // Add new record with the new Id
            prizes.Add(model);

            // Convert the Prizes to a list of string
            // Save the list of strigs to txt file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }

        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

            int currentId = 1;

            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;
            people.Add(model);
            people.SaveToPeopleFile(PeopleFile);
            return model;
        }

        public List<PersonModel> GetPerson_All()
        {
            throw new NotImplementedException();
        }
    }
}
