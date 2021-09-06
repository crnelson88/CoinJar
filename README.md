# CoinJar
To keep your coins in a coinjar


## How to run CoinJar

Coin jar can be run on Azure
https://coinjarapi.azurewebsites.net/swagger/index.html

OR

By adding the emailed appsettings to the solution and running it.

### How to add a coin

Coins will be added by specifying the type of coin to be added. The types of coins are shown in the swagger documentations.

When you add a coin some hardcoded values are set for the volume the coins will take up.


                Cent will take up 2 Fluid Ounces and has an amount of 1c
                Nickel will take up 4 Fluid Ounces and has an amount of 5c
                Dime will take up 5 Fluid Ounces and has an amount of 10c
                QuarterDollar will take up 6 Fluid Ounces and has an amount of 25c
                HalfDollar will take up 8 Fluid Ounces and has an amount of 50c
                Dollar will take up 10 Fluid Ounces and has an amount of 100c
               
When adding a coin you will get a error with code 500 when the jar is too full to accept your coin.
The error message will state that the jar is too full to accept your coin.
