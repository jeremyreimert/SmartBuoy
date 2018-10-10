# SmartBuoy
Smart water quality testing probe

The SMARTbouy was designed to be a fully self-contained water quality probe, 
able to be deployed into a body of water and monitored remotely via a GSM cellular network. 
The SMARTbuoy is an economical solution to water monitoring, 
meant for both amateur and professional researchers. 

Our current build includes a 3.7volt lithium ion battery, charged using a solar panel,
and provides data for electrical conductivity, pH, temperature, turbidity, and total dissolved solids. 
Battery level and GPS data are also provided. Each reading is given a date and time stamp and recorded 
to an onboard SD card in CSV format.  Additionally, each reading is printed on a serial monitor when 
attached to a computer via USB. Access to the cellular network is provided by a SIM900 series modem, 
and readings are “dweeted” using the dweet.io API. We have created a freeboard.io dashboard 
as a GUI which pulls data from dweet.io.

Future additions to the build will include more advanced sensors and 
connectivity between a network of SMARTbuoys. We also researched smartphone 
dashboard apps for mobile access and found Blynk to be a suitable candidate. 
