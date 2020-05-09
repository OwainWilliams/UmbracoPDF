# How to create PDFs on the fly with Umbraco.
## Setup

I had the requirement from a client to create a PDF of a page. The page had to be CMSd and the PDF should be dynamic. The site has what we
called a basket. The visitor to the website could select items that they wanted to save for later reference in to the basket. Then the 
PDF could be created on the fly, pulling in the items from the cart and also pulling in the CMS'd header, footer and other items.

In this tutorial, I'll cover the PDF setup and the Umbraco setup. The basket was saved as a JSON object, deserialized and added to the PDF.

# Umbraco Setup.
I originally created this in an Umbraco 7 website but this tutorial will be for Umbraco 8. It will be on a clean install and the code is attached below.

Let's open up Visual Studio and use Nuget to install Umbraco CMS. For detailed instructions on setting up Umbraco, visit [our.umbraco.com](https://our.umbraco.com/download/)

The project that I've included in this tutorial has the following login details:

Admin: admin@pdfproject.com

Password: pdfproject

I have two projects within my Visual Studio Solution. UmbracoPDF and UmbracoPDF.Core. 

`UmbracoPDF.Core` has the following references added, all these files are also within the `UmbracoPDF` project and so I just add a reference from the `UmbracoPDF` bin folder to the .Core project:

`Umbraco.Core`
`Umbraco.Web`
`System.Web.Http`
`System.Web.Mvc`
`Rotativa`

I have also added `Umbraco.ModelsBuilder.Embedded` because I have moved the default Models location from the main project to my `.Core` project so that I can use the models with my controllers. 

# How will we create PDFs?
I used [Rotativa](https://github.com/webgio/Rotativa) 1.7.3, which is a free nuget package which can be used in ASP.net MVC projects. When it's installed, it needs to be in the UmbracoPDF project. There is a reason for this which I'll explain in a bit.  
 
So we have Umbraco installed and Rotativa installed. Now we need to hook it all together. 

Let's start by making an external website in to a PDF. 
This will demonstrate that Rotativa is installed correctly and generating PDFs.

The View:


![Basic View](/Blog/Images/pdfView.png)


The Controller:

 ![Basic Controller](/Blog/Images/pdfController.png)
 
 When you load up the project, all this will do is place a link on the homepage that a user can click. When the user clicks the link Rotativa goes away and reads the website and converts it to a PDF which then downloads on to your computer. For this example, the PDF will download with the name `OwainCodes.PDF`. We now have Rotativa working and it's time to make it work with some Umbraco content.
 
 ## Umbraco Content and Rotativa PDF
 
My plan here is to make what I call a Content Block. It's a Nested Content element which I will drop on to a page. This makes the element optional and I can place it on any page that I want. 
The first thing I need to do is setup my Nested Content element within Umbraco. In the backoffice I've created two folders, one for my compositions and another for my Content Blocks. 


