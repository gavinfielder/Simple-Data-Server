# Simple Data Server

This web app handles a persistent data source which stores an ID, a floating-point value, and a timestamp. 

I am building this as an educational tool. My learning goals for this project are:
 - ASP.Net
 - WCF
 - SQL Server
 - Oracle (coming soon)
 - Real time data views (coming soon)
 - Deployment on AWS using EC2, Elastic Beanstalk, and AWS toolkit for Visual Studio

## Design
I used a non-scaffolded MVC. The website and WCF service are separate deployments on the same server using an Amazon EC2 windows instance. The SQL Server instance is hosted on a separate server using Amazon RDS, as will the Oracle when it's deployed.

![Design diagram](https://i.imgur.com/QHEfSOq.png)


## Current Deployment
It is currently deployed on AWS. The latest deployment can be seen [here](http://rgftestdeploy.us-east-2.elasticbeanstalk.com/). 


Last updated 8/3/2018