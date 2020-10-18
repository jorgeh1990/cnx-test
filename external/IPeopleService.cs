
using System.Threading.Tasks;
using Refit;

namespace CNX.TEST
{
    public interface IPeopleService    {

        [Get("/People")]
        Task<PeopleResponse> GetPeople();
    }
}