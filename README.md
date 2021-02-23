# Access Control

For Fun Physical Access Control system (door lock and alarm) - Raspberry Pi, .NET 5, ASP.NET, Azure IoT Hub.

Originally, built in 2018-2019. Code refactored in February 2021.

For configuration, see the documentation.

[Video: WebApp](https://www.youtube.com/watch?v=VlSKTeJASYc)

[Video: Push Notifications](https://www.youtube.com/watch?v=9nb2P9FmH2Y)

## Purpose

Learning about building microservices, better structuring code, and some electronic low-level programming.

Expressing my creativity - having fun.

## Parts

The project consists of the 2 main services:
* AppService
* AccessPoint

It also contains these apps: 
* Web App (Blazor)
* Mobile App (Xamarin.Forms)

## Updates

Since publishing this project, I have been updating everything to .NET 5, from an earlier version of .NET Core.

There has been some drastic restructuring going on since then.

My goal is to recreate my original Raspberry PI set up, and to create guides on how to set everything up.

## Screenshots

### Web App

#### Alarm
<img src="/images/screenshots/webapp-alarm.png" />

#### Access Log

<img src="/images/screenshots/webapp-accesslog.png" />

### Raspberry Pi

<img src="/images/photos/pi-accesspoint.jpeg" />

## Architecture
* Clean architecture, CQRS with Mediator-pattern.
* Azure Services - IoT Hub, Notification Hub

### Using Project Tye

Having the Tye global tools installed.

To run the projects simply write the following command when in the root directory:

```
tye run
```

## Services

### AppService
Responsible for handling requests and granting access to an AccessPoint.

It is controlled through a Web API, which both the Web App and Mobile App uses.

Communicates with AccessPoint through IoT Hub and Event Hub.

The service also sends Push Notifications to phones that have the Mobile App installed.

### AccessPoint
Represents a physical AccessPoint. (There can be multiple AccessPoints)

It controls the hardware on behalf of the App Service.

Runs in Raspberry Pi OS (Raspbian), on a Raspberry Pi. 

It can even run in a Docker container, if desired.

Peripherals:
* RFID reader
* Relay
* LED
* Button

Uses the ```System.Devices``` package.

## Apps

### Web App
Basic UI for monitoring the system.

Functionality:

* Request access (Arm and Disarm)
* Create identities. 
* View  Live Access Logs

### Mobile App

Functionality:

* Request access (Arm and Disarm)
* Receive Push Notifications.

Currently only the Android app is working

## Development requirements

* .NET 5.0.* SDK for building

Addional tools:

* Project "Tye" - to simplify launching and running multiple services in parallel when developing.

## Running the project

You can run services separately but that requires some configuration. Instead, Project Tye is strongly recommended.

## Todo
Here is a list of what is to be dones:

* Refactor code

* Access Point
    * Introduce Clean Architecture

* Web App
    * Upgrade to Bootstrap 5
    * Fix user experience

* Data
    * Seed initial and test data in database

* Configuration
    * Improve storing and retrieving settings, including connection strings.

* Docs
    * Improve docs on configuration