using PruebaC_sharp_Herbin_Restrepo.Models;

var catN = new Cat(1,"Pocaluz",new DateOnly(2008, 10, 05),"Siames","brown",10,true,"60cm");

var dogN = new Dog(1,"Chandy",new DateOnly(2008, 10, 05),"Dalmata","white and black",20,true,"60cm",546478,15,"Moderate");

ManagerApp.ShowHeader();

ManagerApp.MenuShow();

ManagerApp.SwichtMenuOPtions();

ManagerApp.ShowFooter();