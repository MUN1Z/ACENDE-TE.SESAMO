using ACENDE_TE.SESAMO.Mobile.Models;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ACENDE_TE.SESAMO.Mobile.Services
{
    public interface IService
	{
		[Get("/api/Light")]
		Task<List<Light>> GetAllLights();

        [Post("/led")]
		Task Test([Body] Light light);
	}
}
