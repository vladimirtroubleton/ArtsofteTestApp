using ArtsofteTestApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtsofteTestApp.Repositories
{
    public class ProgrammingLanguageDataRepository : IProgrammingLanguageDataRepository
    {
        public AppContext dbcontext;

        public ProgrammingLanguageDataRepository(AppContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public void SaveNewProgLanguageRecord(ProgrammingLanguageModel model)
        {
            dbcontext.ProgrammingLanguages.Add(model);
            dbcontext.SaveChanges();
        }

        public List<ProgrammingLanguageModel> GetAllProgLanguageRecord()
        {
            return dbcontext.ProgrammingLanguages.ToList();
        }

        public void RemoveProgLanguageRecord(ProgrammingLanguageModel model)
        {
            dbcontext.ProgrammingLanguages.Remove(model);
            dbcontext.SaveChanges();
        }

        public void EditProgLanguageRecord(ProgrammingLanguageModel model)
        {
            dbcontext.Entry(model).State = EntityState.Modified;
            dbcontext.SaveChanges();
        }

        public ProgrammingLanguageModel FindProgLanguageById(int id)
        {
            return dbcontext.ProgrammingLanguages.Find(id);
        }
    }
}
