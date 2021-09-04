using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoinJar.Api.Model
{
    public class AddCoinRequest
    {
        [Required(ErrorMessage = "Amount is required")]
        public decimal Amount { get; set; }
        [Required(ErrorMessage = "Volume is required")]
        public decimal VolumeInFluidOunces { get; set; }
    }
}
