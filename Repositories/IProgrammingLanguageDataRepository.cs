using System.Collections.Generic;
using ArtsofteTestApp.Models;

namespace ArtsofteTestApp.Repositories
{
    public interface IProgrammingLanguageDataRepository
    {
        void EditProgLanguageRecord(ProgrammingLanguageModel model);
        ProgrammingLanguageModel FindProgLanguageById(int id);
        List<ProgrammingLanguageModel> GetAllProgLanguageRecord();
        void RemoveProgLanguageRecord(ProgrammingLanguageModel model);
        void SaveNewProgLanguageRecord(ProgrammingLanguageModel model);
    }
}