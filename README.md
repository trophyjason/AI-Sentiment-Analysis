# 441101-2223-Capstone-Project

## Encapsulation and cohesion 

The solution contains classes grouped to either being a menu item (for selection) or menu (containing menu items) or project (with types of projects and project manager) and has a consolehelpers (static) and interface class to avoid redundancy and repetition. This makes all classes cohesive. Also, all classes and properties are correctly encapsulated and do not fulfil too many functions, being appropriate for the given problem. For example, the addnewbuildmenuitem class is a menu item that when the user selects new build from addnewprojectmenu asks the user to input the amount for a new build and creates a new build. This only performs one function which is to ask user for amount for new build and create a new build with that amount (basically used to create a new build). Also, the consolehelpers allows for multiple classes to use the same code from the methods in the consolehelpers class without repeating the same code twice. For example, the summaryheadings method from the consolehelpers class is used for all summary classes so the same code does not need to be repeated but values for the parameters could be given for the different classes. Sales, purchases and creation of projects cannot have an amount that is less than zero and a project can only be either a land or renovation. Also, static classes  

## Inheritance for code reuse 

A new build and renovation are both projects and inherit all properties and methods from the project class. For example, newbuild class inherits the method addpurchase from the project class and properties such as id, purchase and sale when a newbuild is created. Also, consolemenu class is inherited by all menus and gives its method like select to other classes allowing for same functionality for all child classes. This allows code to be reused through inheritance and avoids repetition. 

## Polymorphism 

All opportunities to use polymorphism have been done and allows child classes to override parent class behaviour. A method called refund is used in the project class and made virtual so that it could be changes in the child class. In the newbuild class refund is overridden because a refund is given to newbuild projects, but it is not overridden in the renovation class, so the renovation class uses the code in the refund method of the parent class. Also, the tostring method is overridden in the consolemenu class which overrides the tostring method in the object main class allowing the consolemenu class to have a different tostring method from its parent class.

## Abstraction, interfaces and low coupling 

The interface called imenuitem has been created and has two methods called select and menu text. This causes all classes that use interface to be forced to implement the two methods otherwise the code crashes which ensures all functionality has been created for all menu items. Also, the abstract class consolemenu contains two abstract methods createmenu and menutext which are to be implemented in all menu classes that inherit from it otherwise the code will crash as well. 

## Self commenting code, explicit comments and use of source control 

Source control has been used throughout with multiple commits and pushes and have meaningful log messages for how far I reached during the assignment when I committed to git. All member variables begin with an underscore, all variables have meaningful identifiers and use camel case and all methods have meaningful identifiers that use Pascal case. 

## User interaction 

All functionality for the program has been implemented using a flexible reusable object-oriented menu system. All errors have been handled if the user enters wrong data and feedback is given for wrong data entry. 

## File Loading (format 1 & format 2) 

Any file can be loaded given that it exists, and feedback is given for any errors based on user input. Also, if there are any errors with the file, any data that was read before the error is stored and the program tells the user the first error it encounters and closes the file. All formats of files can be loaded, and all functionality has been implemented. 

## Project handling 

All projects created through the file or by manual creation can be selected and handled. When the project is selected the user can view all sales created, all purchases made, whether it is a build, or a renovation and you can get a summary of all transactions showing the refund to be returned and the profit made. You can also create new purchases or sales. 

## Portfolio handling 

The whole portfolio summary can be viewed showing all the projects. You can also create new projects as new builds or renovations and remove existing projects. Any project created through loading the file or by manual creation can be selected and handled. A list of all projects can also be viewed, and you can select any project. An overall summary of all projects created can also be viewed at the bottom of the portfolio summary. 
