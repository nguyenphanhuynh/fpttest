Create a console app in C# (.NET Core/.NET FW/.NET5)
•    Prompt user for zipcode
•    Call this service to get the weather:
        http://api.weatherstack.com/current?access_key=610acf4c1d203448cd6f671955c5e8aa&query=30076

Answer for the user the following questions:
    - Should I go outside?
        + (Yes if it’s not raining)
        + (no if it’s raining)
    - Should I wear sunscreen?
        +Is UV index above 3 then YES
    - Can I fly my kite?
        +Yes if not raining and wind speed over 15

Please implement it in a way that it's easy to mantain/extend later on, and the codes are clean/readable