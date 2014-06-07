using System.Collections.Generic;
using System.Web.Mvc;
using Contract;
using Data;
using Domain;
using Microsoft.Practices.Unity;
using Unity.Mvc4;

namespace PowerGridMVC
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();

      // register all your components with the container here
      // it is NOT necessary to register your controllers

      // e.g. container.RegisterType<ITestService, TestService>();  
      container.RegisterType<IGeoRepository, GeoRepository>(new InjectionConstructor(new List<Geo>()));
      container.RegisterType<IAreaRepository, AreaRepository>(new InjectionConstructor(new List<Area>()));
      container.RegisterType<ISubsidiaryRepository, SubsidiaryRepository>(new InjectionConstructor(new List<Subsidiary>()));
        container.RegisterType<ITimeZoneRepository, TimeZoneRepository>(new InjectionConstructor(new List<Timezone>()));

      RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
    
    }
  }
}