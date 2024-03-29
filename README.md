# Pierre's Bakery

#### This project acts as an ordering system for a bakery.

Created by: [github.com/mejia-dev](https://github.com/mejia-dev)


## Technologies Used

* C#
* MSTest


## Description

This project utilizes C# to allow users to purchase bread and pastries.
Pierre offers the following deals:
* Bread: Buy 2, get 1 free. A single loaf costs $5, then every 3rd loaf of bread is free.
* Pastry: Buy 3, get 1 free. A single pastry costs $2, then every 4th pastry is free.


Features:
* Allows users to purchase bread and pastries, then will calculate the price of the order.


## Setup/Installation Requirements

##### Step 1: Download .NET SDK
* Download the .NET 6 SDK (Software Development Kit). To view all download options for the .NET 6 SDK, visit this page. Or, click on any of the following links for an immediate download from Microsoft:

  For [Windows](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.402-windows-x64-installer)

  For [Macs with Apple Chip](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.402-macos-arm64-installer)

  For [Macs with Intel Chip](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-6.0.402-macos-x64-installer)


##### Step 2: Install the SDK
* Open the file. This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.


##### Step 3: Test Installation
* Confirm the installation is successful. First, restart your command line shell (Terminal or GitBash) if it's already open, and then run the command "dotnet --version" (without quotes). You should see a version number as a response.


##### Step 4: Clone Repo
* Clone this repository to your desktop by, running the following command from your Git Bash console:
  ```bash
   git clone https://github.com/mejia-dev/pierres-bakery.git
   ```


##### Step 5: Run project
* Navigate to the project directory, and to the project subfolder:
  ```bash
  cd pierres-bakery/PierresBakery
  ```

* Run the following command to install dependencies:
  ```bash
  dotnet restore
  ```

* Run the project using:
  ```bash
  dotnet run
  ```

## Known Bugs

* none

## License

MIT License

Copyright (c) 2023 github.com/mejia-dev

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
