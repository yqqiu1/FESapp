using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;

namespace FESapp
{
public interface ApiService
    {
        [Get("/chapters")]
        Task<List<Chapter>> getchapter();

        [Get("/tests")]
        Task<List<QuizModel>> getTests();

        [Get("/checklists")]
        Task<List<Checklists>> getchecklists();




    }
}
