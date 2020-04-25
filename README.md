# SmartBuoy
Remote water quality testing probe

Background: 	SmartBuoy was designed as a fully self-contained water quality probe, able to be deployed in a body of water and monitored               remotely via a GSM cellular network. SmartBuoy is an economical solution to water quality monitoring, meant for both                     amateur and professional researchers. 

The device is powered by 5-volt lithium ion battery, recharged by an onboard solar panel and includes sensors to measure                 electrical conductivity, pH, temperature, turbidity, and total dissolved solids. Location data is provided by an Adafruit               GPS module. A data reading is taken every 15 seconds and streamed live. Every hour a reading is sent to a database for                   storage.  
              
Scope: 	      This portion of the project provides a dashboard to retrieve and view the data readings, both live and historic. In                     addition to the dashboard, a second application was developed to simulate the operation of the SmartBuoy. This allows for               testing and review of the dashboard application without requiring the deployment of the device. This is also beneficial in               situations where development and testing are done without access to the SmartBuoy. In addition to the dashboard and                     simulator, a database has been created for data storage.

 Dweet.io is used as an intermediary for the retrieval of  live updates from the device.  In this case, the simulator                     generates the reading data and sends it to Dweet.io using an Http client. Dweet.io stores the five most recent data                     readings. The dashboard then retrieves the most recent reading, also using an Http client. These readings are sent and                   retrieved every 15 seconds. Once per hour a reading is also sent to the database for storage. The database was built using 		           Microsoft Azure and is accessed using LINQ – part of the Microsoft.NET Framework.           

Operation: 	  After opening the Dashboard application you will be presented with the interface. Five main areas will be visible: gauge                 cluster, map, data table, line chart, and controls. There are two datetime pickers in the controls section; one for the                 start date and one for the end date. Setting these values will provide the date range of the reading to be retrieved from               the database. 

 Clicking the button marked “GET DATA” will execute the retrieval. You will see the data appear as rows in the data table                 and in the line chart. You will also see the locations of each reading marked on the map. A row of the data table will be               highlighted in green; the values of this row’s cells are mapped to the gauges. Use the range slider to move through the                 rows of data. You will see the gauge values change to match the newly highlighted row. The cell values of the selected row               will also be the final data added to the map and chart.
              
	            Clicking the button marker “GO LIVE” will retrieve the latest data reading from Dweet.io. If the simulator running, you                 will see data begin to fill the data table, chart, and map. The gauges will reflect the most recent data. If the simulator               is not running, a single reading – the most recent in Dweet.io will be displayed – no other data will appear.
              
 	            To use the simulator, first launch the application, you will then see the interface. There is a large power button.                     Clicking this button starts/stops data generation and transmission. As the simulator operates, data is generated and                     transmitted. Picture boxes containing images of LEDs are used indicate that the unit operational. The application uses LED               images indicating  power status, live streaming, database transmission, and generation of each data point.

             


