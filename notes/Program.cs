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
/*
https://loiane.com/2017/08/angular-reactive-forms-trigger-validation-on-submit/
https://rishabh.io/misc/angular-4-project-structure.html
http://gunnariauvinen.com/what-is/
https://codecraft.tv/courses/angular/pipes/overview/
https://www.sitepoint.com/ultimate-angular-cli-reference/

                                     *** Angular Module 1 ***
************************************************************************************************************

** Angular 4 : Features :

  |- It is a framework for building client applications in HTML and either JavaScript or a language like T
     TypeScript that compiles to Javascript.

  |- "Open Source"

  |- "Web Development Framework"

  |- Maintained by "Google"

  |- Also utilized in the cross plateform mobile development framework called IONIC and so it's not limited to
     web apps only.

  |- Angular uses "semantic versioning" since Angular 2, which requires the major number being increased when
     "breaking changes" were introduced. This issue is no more available in Angular 4.

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
                                     --> It understands templates and can convert them to code that makes the
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
  
          | -devDependencies :-
              | -The package listed in this section of the package.json helps user to develop  the application.
  
              | -(concurrently)-- > A utility to run multiple npm commands concurrently on OS / X, Windows,
                                   and Linux operating systems.
  
              | -(lite - server)-- > A light - weight, static file server, by John Papa with excellent support
                                for Angular apps that use routing.

            | -(typescript)-- > the TypeScript language server, including the tsc TypeScript compiler.

            | -(@types/*:) --> TypeScript definition files.


      (2) tsconfig.json:
           |- It is a root directory of a TypeScript project.
           |- It is also used to define different typescript compilation related options.
           |- It is TypeScript configuration file to guide the compiler.
           |- It contains options and flags that are essential for angular applications.
                             
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
    |-environments
    |-favicon.ico
    |-index.html
    |-main.ts
    |-polyfills.ts
    |-style.css
    |-test.ts
    |-tsconfig.app.json
    |-tsconfig.apec.json
    |-typing.d.ts

 (1) app :-
      |-This is where we define the building blocks of the angular 4 project like modules, components, services etc.
      
 (2) assets :-
      |- This directory contains all the static assets of angular project like images etc.

 (3) environments :-
      |-This directory holds our enviornment specific settings.
      |-For example different configuratiuon files for the development, testing and staging etc.

      |- This directory has two files :
         (a)environment.prod.ts
         (b)environment.ts

 (4) index.html :-
      |- It is the landing page or main page of our application and this is where our angular app bootstraps.
      |- It has a  "<app-root> </app-root>" selector.

 (5) main.ts :-
      |- It is the main typescript file which is used to bootstrap the angular module.
      |- The check for environment is also performed here.

          ==> import { environment } from './environments/environment';
              if (environment.production)
                {
                   enableProdMode();
                }

**************************************************************************************************************
**************************************************************************************************************
**************************************************************************************************************

                                     *** Angular Module 5 ***
**************************************************************************************************************
 **APP DIRECTORY STRUCTURE ::
    |- app.component.css
    |- app.component.html
    |- app.component.spec.ts
    |- app.component.ts
    |- app.module.ts

 (1) app.module.ts :-
      |- Here "angular module" is declared.
      |- "@NgModule" decorator is used to initialize different aspects of the angular app.

 (2) app.component.ts :-
     |- This file defines an angular component.
     |- This is where we defines our 'app-root' selector also.

 (3) app.component.html :-
     |- This is the template file for our app component.
     |- It represents the visual part of our component which is rendered in the browser.

Note :- "{{ }}" --> This is used for binding component data to template.

 (4) app.component.css :-
     |- This is the style file for the component and this is where we define custom styles for our components.

 (5) app.component.spec.ts :-
     |- These files are unit tests for the source files.
     |- we have (.spec.ts) file for all (.ts) file.
     |- They runs using "Jasmine javascript test framework" through "Karma" task runner when "ng test" command 
        is used.

**************************************************************************************************************
**************************************************************************************************************
**************************************************************************************************************

                                     *** Angular Module 6 ***
**************************************************************************************************************

** ANGULAR 4 COMPONENTS ::
    |- These are the cells or building blocks of an Angular app.
    |- These are "TypeScript" classes along with a component decorator where we provide metedata that dictates
       how the component should be used by the app.
    |- It must belong to "NgModule".
    
** HOW TO CREATE NEW COMPONENTS ::
    |- Use this command to generate new component in app directory.
 
       --> "ng g component Component_Name" or "ng g c Component_Name"

** ngOnInit() ::
    |- It is a "lifecycle callback" method.

    |- A component has a life cycle which is looked after by angular and there are several life cycle
      callbacks invoked at different intervals.

    |- "OnInit" is an interface which has a hook method named "ngOnInit()" that angular calls shortly after
       creating the component.


** TWO WAY DATA BINDING and (*ngFor) ::
    |- (*ngFor) is used to display multiple values.

    |- [] --> These brackets are used to bind view elements to component.

    |- () --> These are used to take action on different events like click, dataChange etc.

    |- In order to achieve two way data binding we use  " [(ngModel)] " .

    |- [(ngModel)] is an angular directive.   

    |- *ngFor --> It is an Angular syntax to iterate through array.

    |- {{}} --> Are used to bind values to view or template.


Note :- (1) To install bootstrap use
 
              ==> npm install bootstrap@4.0.0-beta --save

           and then in angular-cli.josn add 

           ==>  "../node_modules/bootstrap/dist/css/bootstrap.min.css",
   
                "styles.css" 
     
          in "styles":[] section.

       (2) To install jquery use 

           ==> npm install jquery --save

            
           and then in angular-cli.josn add 

          ==> "../node_modules/jquery/dist/jquery.slim.js/",
   
              "../node_modules/bootstrap/dist/js/bootstrap.min.js"

           in "scripts":[] section.

**************************************************************************************************************
**************************************************************************************************************
**************************************************************************************************************

                                     *** Angular Module 7 ***
**************************************************************************************************************

** SERVICES IN ANGULAR 4 ::
    |- These are reusable entities which are instantiated once and can be used by multiple componenets.

** WHEN TO USE SERVICES ::

    |- When we need to use same data in multiple components then it's good to create service instead of 
       instantiating the data objects again and again.

    |- When using services , modification of source of data is easier.
    |- In case of consuming " rest API" , we only need to update the service code instead of updating data
       at all places.

** CREATING A SERVICE IN ANGULAR ::

    ==> ng g service component_name


   |- this command will generate two files 
     (1) Prject_name.service.ts
     (2) project_name.service.spec.ts  :- These ae used to write "test cases" .

  |- "@injectable()" :- It is a decorator in angular.

**************************************************************************************************************
**************************************************************************************************************
**************************************************************************************************************

                                     *** Angular Module 8 ***
**************************************************************************************************************
** MODULE ::

   |- Angular apps are modular and Angular has it's own modularity system called "NgModules".

   |- Every Angular App has at least one NgModule class, the "root-module", conventionally named "Appmodule".

   |- An "NgModule", whether a root or feature, is a class with an @Ngmodule decorator.

   |- Decorators :-
       |- These are functions that modify JavaScript classes.

   |- "NgModule" is a decorator function that takes a single metadata object whose properties describes the 
       module. The important properties are :

      (1) declarations --> the "view classes" that belong to this module.

           |- Angular has three view kinds of view classes :-

              (a)components :-

                  |- A component controls a patch of screen called a view.

                  |- We define a component's view with it's companion template.

                  |- A template is a from of HTML that tells Angular how to render the component.

                  |- A template looks like regular HTML, except for  a few differences.

                  |-
             
              (b)directives :-

                  |- It is a class with  " @Directive " decorator .

                  |- A component is a dirctive with a template.

                  |- "@component" decorator  is actually a " @Directive" decorator extended with template
                     oriented features.

                  |- component is technically a directive.

                  |- There are two types of directives :-

                    (a)structural  
                        |- They alters layout by adding, removing, and replacing elements in  DOM.

                        |- Example --> (*ngFor) and (*ngIf)   
                 
                    (b)attribute 
                        |- They alters the appearance or behaviour of an existing element.   
                    
                        |- Example --> [(NgModel)]   

                        |- Angular has a few more directives that either alter the layout structure (for 
                           example, [ngSwitch]) or modify aspects of DOM elements and components
                          (for example, [ngStyle] and [ngClass]).    

              (c)pipes :-
                  |- It takes in data as input and transforms it to a desired output.
                  |- It is denoted by "|" (pipe operator)
                  |- {{}} --> Interpolation
               
       (2) Exports :- 
            |- The subset of declarations that should be visible and usable in the component templates of 
               other modules.

       (3) Imports:-
            |- Other modules whose exported classes are needed by component templates.

       (4) Providers :-
            |- Creators of services that contributes to the global collections of services.
            |- They can be accessed everywhere in.
      
       (5) Bootstrap :-
            |-This is the main application view, called the " root component " ,that hosts all other app views
            |-Only the root module should set this bootstrap property.

**************************************************************************************************************
**************************************************************************************************************
**************************************************************************************************************

                                     *** Angular Module 9 ***
**************************************************************************************************************

** ANGULAR LIBRARIES :-
    |- Angular ships as a collection of javaScript modules which is nothing but library modules.
    |- Each Angular library name begins  with the " @angular " prefix.

** METADATA :-
   |- It tells angular how to process a class.
   |- In TS we can attach netadata by using a decorator.

   -->  @Component({
        selector:    'hero-list',
        templateUrl: './hero-list.component.html',
        providers:  [ HeroService ]
                 })
        export class HeroListComponent implements OnInit {
        /* . . . */
        }
 /*          
  ==> " @component " decorator, which identifies the class immediately below it as a component class.

  ==> Here are a few of the most useful @Component configuration options:

      (a) selector :-
           |- CSS selector that tells Angular to create and insert an instance of this component.

      (b) tempalteUrl:-
           |- module-relative address of the component's HTML template.

      (c) Providers :-
           |- Array of dependency injection providers for services that the component requires.

           |- A provider is something that can create or return a service, typically the service class itself.

           |- You can register providers in modules or in components.

           |- In general, add providers to the root module so that the same instance of a service is available
              everywhere.

    |- The metadata in the @Component tells Angular where to get the major building blocks that we specify
       for the component.

    |- The template, metadata, and component together describe a view.

 
** DATA BINDING :-
    |- It is a mechanism for coordinating parts of a template with parts of a component.

    |- Data binding plays an important role in communication between a template and its component.
   
    |- There are 4 forms for data binding syntax.Each form has a direction -- to the DOM, from the DOM ,
       or in both directions.

      (1)
{ { value } }               --> one way data binding
(2) [property] = "value"      -->         "
      (3) (event) = "handler"       -->         "
      (4) [(NgModel)] = "property"  --> TWo way data binding

    |- Angular processes all data bindings once per JavaScript event cycle,
       from the root of the application component tree through all child components.
   
    |- Data binding is also important for communication between parent and child components.

**SERVICE :-.

  |-A service is typically a class with a narrow, well-defined purpose.
  |- Angular has no definition of a service.

** DEPENDENCY INJECTION :-

    |- Dependency injection is a way to supply a new instance of  a class with the fully-formed dependencies
       it requires.

    |- Most dependencies are services.

    |- Angular uses dependency injection to provide new components with the services they need.

    |- Angular can tell which services a component needs by looking at the types of its constructor
       parameters.

    |- When Angular creates a component, it first asks an injector for the services that the
       component requires.

    |- An injector maintains a container of service instances that it has previously created.

    |- If a requested service instance is not in the container, the injector makes one
       and adds it to the container before returning the service to Angular.

    |- When all requested services have been resolved and returned, Angular can call the
       component's constructor with those services as arguments. This is dependency injection.

Notes :- 
  (1) Dependency injection is wired into the Angular framework and used everywhere.

  (2) The injector is the main mechanism.
       |- An injector maintains a container of service instances that it created.
       |- An injector can create a new service instance from a provider.
       |- A provider is a recipe for creating a service.
       |- Register providers with injectors.


**************************************************************************************************************
**************************************************************************************************************

                                     *** Angular Module 10 ***
************************************************************************************************************** */



          