using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notes
{
    class Program
    {
        static void Main(string[] args)
        {
            /**/


        }
    }
}

https://rishabh.io/misc/angular-4-project-structure.html
http://gunnariauvinen.com/what-is/
https://codecraft.tv/courses/angular/pipes/overview/
https://www.sitepoint.com/ultimate-angular-cli-reference/
/*
                                     *** Angular Module 1 ***
************************************************************************************************************

** Angular 4 : Features :

  |- "Open Source"

  |- "Web Development Framework"

  |- Maintained by "Google"

  |- Also utilized in the cross plateform mobile development framework called IONIC and so it's not limited to
     web apps only.

  |- Angular uses "semantic versioning" since Angular 2, which requires the major number being increased when
     "breaking changes" were introduced.This issue is no more available in Angular 4.

  |- It requires TypeScript (2.1+)

  |- It Supports TypeScript 2.1 and 2.2

  |- Smaller & Faster

  |- Introduced own package for Animation Package i.e --> @angular/platform-browser/animations.
     It is pulled out from "@angular/core". This means that the bundle we ship to our users will not include
     useless code if we don't use animations in our app.

  |- New "View Engine" which improves the compilation setup Which further results in smaller application size
     compared to earlier iterations.

  |- Improved* ngIf and* ngFor.We can now use an "if/else" style syntax, and assign local variables such as
     when unrolling an observable.  

  |- template is now ng-template.

  |- Source Map for Templates

  |- Fast Compiler

  |- "Else Clause" has been introduced
 
  |- Render has been named to "Renderer2" --> "@angular/core"

  |- "Email Validator" has been added.

  |- "Flat Modules" which makes "importing" easier behind the scene.This would allow build tool to "tree shake"
     the code (code which are not used would be removed).
  
  |- Improved "AOT" (Ahead Of Time Compilation View Engine):

        |- In this mode Angular compiles the templates during the "build", and generates JavaScript Code (But
           in "Just In Time" mode, this compilation is done at run time, when the application starts).

           It gives the error if one of the templates is incorrect at build time instead of having to wait at
           run time, and the application starts faster (as the code generation is already done)

  |- Addition of "as" keyword :
       |- used to simplify "let" syntax.
          It allows to store a result in a variable of the template,to use in the element.

  |- Addition of "titlecase" pipe :
      |-It changes the first letter of each word into uppercase.

  |- Adding search parameters to an "HTTP request" has been simplified :-

          <-- http.get(`${ baseUrl}/ api / races`, { params: { sort: 'ascending' } }) -->

| -Overriding a template in a test has also been simplified :-

< --TestBed.overrideTemplate(RaceComponent, '<h2>{{race.name}}</h2>'); -->

| -A new service has been introduced to easily get or update meta tags.

  | -"compareWith" :-A new directive has been added to help user compare options from a select.

 | -"ParamMap" :-This is a new interface to represent the parameters of a URL.

                 <-- params = paramMap -->
                    <-- queryParams = queryParamMap-- >

| -"canDeactivate" :- This interface has an extra parameter , containing the next state(where we have to
                        navigate).


*************************************************************************************************************
*************************************************************************************************************
*************************************************************************************************************

                                     *** Angular Module 2 ***
 *************************************************************************************************************

   ** HOW TO START :

   |- node.js >= 6.9.x(6.11.2)
   
   |- npm >= 3.x.x (3.10.10)
   
   |- Visual Studio Code 
                                     
   |- (node -v) --> To check the current version of node

   |- (npm -v) --> To check the current version of npm

   |- (npm install @angular/cli -g) --> To install "@angular/cli" , it is an npm package

   |- After installing angular/cli , in cmd change directory where you want to create the project(cd path)
  
   |- (ng new projectName) --> It is used to create new project/application in angular 4.
                               It is @angular/cli tool.
                               This command creates the bare bones angular apps for user creating  and placing
                               initial files and folders at right place.

  |- (ng serve) --> It is @angular/cli tool.
                    It lifts the project on local machine at "http://localhost:4200" (By Default)

  |- (ng serve --port xxxx) --> By this we can define our own port (xxxx can be any four digit number).

  |- (npm start) --> This is also used to lift the project on local machine ("http://localhost:4200") (By Default)

******************************************************************************************************************
******************************************************************************************************************
******************************************************************************************************************

                                       *** Angular Module 3***
**************************************************************************************************************
 **ANGULAR PROJECT STRUCTURE :
    |- It has a well defined structure.
   
    |- Important File and folders in angular 4 :-

      (1) package.json:
           |- It defines all the npm based dependencies , dev-dependencies and npm scripts etc required for
              the angular project.

           |- dependencies :- Are required to "run". It contains:

                  |- Features  :- Feature packages give the application framework and utility capabilities.
                  |- Polyfills :- polyfills plugs gaps in the browser's JS implementation.
                  |- Other     :- Other libraries that support the application such as bootstrap for HTML
                                  widgets and styling
               
           |- devDependencies :- only to develop,e.g. : unit tests, Coffeescript to javascript transpilation,
                                 minification.
                
           
           |- Features :
               |- (@angular/core) --> critical runtime parts of framework needed by every application.
                                  --> Includes all "metadata" decorators, Component, Directive, dependemcy
                                      injection, and the component life cycle hooks.

               |- (@angular/common) --> The commonly needed services, pipes, and directives provided by the
                                       Angular Team.
        
               |- (@angular/compiler) --> Angular's Template Compiler.
                                     --> It understands tempaltes and can convert them to code that makes the
                                         application run and render.

              |- (@angular/plateform-browser) --> Contains Everything thing DOM (Document Object Model) and
                                                 Browser related.
                                      --> Also includes "bootstrapStatic()" method for bootstrapping
                                          applications.

              |- (@angular/plateform-browser-dynamic)

                  --> Includes providers and a bootstrap method for applications that compile templates
                      on the client.
                 --> used for bootstrapping during development and for bootstrapping plunker samples.

             |- (@angular/http:) --> Angular's HTTP client.
             
             |- (@angular/router) --> Component router.

             |- (@angular/upgrade) --> set of utilities for upgrading AngularJS applications to Angular.

         | -Polyfills :-
             | -A polyfill is a code that implements a feature on Web browsers that do
        not support
               the feature.

             | -It refers to a "javascript library" that implements an "HTML5 Web Standard".

             | -It allows web developers to use an API regardless of whether it is supported by browser or not,
                and usually with minimal overload.

             | -Different polyfills may be needed for different browsers. 

             | -(core.js:)
    --> Patches the global context(window) with essential features of ES2015(ES6).
                           -- > We can substitute an alternative polyfill that provides the same core APIs.

| -(rxjs:) --> It is a library for reactive programming using Observables, to make it easier to
     compose asynchronous or callback - based code.

| -(zone.js)-- > A polyfill for the Zone specification currently before the TC39 committee
                             that determines standards for the JavaScript language.

| -Other :-
              | -(angular -in-memory - web - api)

        --> An angular - supported library that simulates a remote server's web api  without requiring
                     an actual server or real HTTP calls.
                  -- > Good for demos, samples, and early stage development.
  
                | -(bootstrap)-- > It is popular HTML and CSS framework for designing responsive web apps.
  
          | -devDependies :-
              | -The package listed in this section of the package.json helps user to develope the application.
  
              | -(concurrently)-- > A utility to run multiple npm commands concurrently on OS / X, Windows,
                                   and Linux operating systems.
  
              | -(lite - server)-- > A light - weight, static file server, by John Papa with excellent support
                                for Angular apps that use routing.

            | -(typescript)-- > the TypeScript language server, including the tsc TypeScript compiler.

            | -(@types:) --> TypeScript definition files.


      (2) tsconfig.json:
           |- It is a root directory of a TypeScript project.
           |- It is also used to define different typescript compilation related options.
           |- It is TypeScript configuration file to guide the compiler.
           |- It conatins options and flags that are essential for angular applications.
                             
     (3) angular-cli.json :
          |-It is a file used by @angular/cli tool which is used to automate the angular workflow by automating
            different operations related to development and testing of angular apps.
          |-It serves as a blueprint to the @angular/cli tool.
          |- @angular/cli uses "webpack" under the hood to automate the angular workflow.

    (4) src :
         |- One of the most important directory in angular project.
         |- This is where we define the actual source code for our application along with all the assets etc.

**************************************************************************************************************
**************************************************************************************************************
**************************************************************************************************************

                                     *** Angular Module 4 ***
**************************************************************************************************************

 **ANGULAR SRC STRUCTURE :
    |-app
    |-assets
    |-enviornments
    |-favicon.ico
    |-index.html
    |-main.ts
    |-polyfills.ts
    |-style.css
    |-test.ts
    |-tsconfig.app.json
    |-tsconfig.apec.json
    |-typing.d.ts
    */