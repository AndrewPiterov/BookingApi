namespace Piter.Samples.Booking.HttpApi.HttpHost

open System
open System.Web.Http

type HttpRoutesDefaults = { Controller: string; Id : obj }

type Global() =
    inherit System.Web.HttpApplication()
    member this.Application_Start ( sender : obj ) ( e : EventArgs ) = 
        GlobalConfiguration.Configuration.Routes.MapHttpRoute(
            "DeafaultAPI",
            "{controller}/{id}",
            { Controller = "Home"; Id = RouteParameter.Optional }) |> ignore