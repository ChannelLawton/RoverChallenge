using System.ComponentModel.DataAnnotations;

namespace MarsRoverApp
{
    public enum CompassValue
    {
        [Display(Description = "N")]
        N = 1,
        [Display(Description = "E")]
        E = 2,
        [Display(Description = "S")]
        S = 3,
        [Display(Description = "W")]
        W = 4
    }
}
