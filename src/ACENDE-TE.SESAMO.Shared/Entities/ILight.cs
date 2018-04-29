using System;

namespace ACENDE_TE.SESAMO.Shared.Entities
{
    public interface ILight
	{
		Guid Guid { get; set; }
        string Name { get; set; }
        int Pin { get; set; }
        bool IsOn { get; set; }
    }
}
