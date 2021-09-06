using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoinJar.Api.Model
{
    public class AddCoinRequest
    {
        [Required(ErrorMessage = "Please select a coin to add to the jar")]
        public CoinType CoinType { get; set; }
    }
}
