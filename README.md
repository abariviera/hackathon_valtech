# Capybara Coding Club presents


# Frontend

### Requirements
  - Node v10.18.6 or greater
  - Gulp CLI

### Running the project in development mode

```sh
$ cd <capybara-coding club/frontend>
$ npm install 
$ npm run develop
```

Fractal should be running on http://localhost:3000


# Backend

### Requirements
  - Running standalone Sitecore 10.1 installation.
  - SQL Server 2019 database server.
  - Visual Studio 2019.
  
### Publishing the project to Sitecore
  - Clone the project to this location: c:/src/
  - From Visual Studio 2019 (henceforth, VS), open the "OneValtech.sln" file.
  - In order to restore all package dependencies, right click on solution name in VS solution explorer and click "Build Solution".
  - Still in VS solution explorer, expand the "Configuration" folder and right click over "Website" project. Then, click on "Publish...".
  - In the project publishing screen, click over the link "Show all settings", in order to point the file publishing to your Sitecore installation.
  - In the "Publish" modal dialog, click on "Connection" tab. Then, in the "Target Location" field, set your Sitecore installation location folder. Right after, click "Save".
  - Back to the project publishing screen, click "Publish".  
  - After this process, access your Sitecore installation from the admin area and log in.
  - Then, in order to synchronize all serialized Sitecore items, you need to access Unicorn UI. In order to do so, access Unicorn from your base Sitecore installation by adding "/unicorn.aspx" to the end of the address on the address bar of your browser. E.G. if your sitecore installation is called from "https://sitecoresc.sc.dev.local/", so, in order to access Unicorn UI, you would call it at "https://sitecoresc.sc.dev.local/Unicorn.aspx".
  - At the Unicorn UI landing page, scroll down to the Initial Setup section and click "Perform Initial Serialization..." button. 
  - After syncronizing unicorn, install the sitecore package located on "sitecorePackage" folder and perform a publish site (smart publish) on /sitecore/content/OneValtech
  - Open the hosts file located on C:\Windows\System32\drivers\etc and add this line at the end of the file:
	127.0.0.1	onevaltech.local
  - Open the IIS, click on your sitecore site, click on Bindings...:
      - Add this site binding config:
          - Type: https
	      - IP address: All Unassigned
	      - Port: 443
	      - Host Name: onevaltech.local
	      - Check the Require Server Name Indication
	      - Select the sitecore instalation SSL certificate
  - After the completion of this process, you'll be able to access the site using this url: https://onevaltech.local/
  
