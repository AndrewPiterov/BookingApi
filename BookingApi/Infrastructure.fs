module Piter.Samples.Booking.HttpApi.Infrastructure

open System.Web.Http

type HttpRoutesDefaults = { Controller: string; Id : obj }

let ConfigureRoutes ( config : HttpConfiguration ) =
    config.Routes.MapHttpRoute(
        "DeafaultAPI",
        "{controller}/{id}",
        { Controller = "Home"; Id = RouteParameter.Optional }) |> ignore

let ConfigureFormatting ( config : HttpConfiguration) =
     config.Formatters.JsonFormatter.SerializerSettings.ContractResolver <- 
        Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver()

let Configure config = 
    ConfigureRoutes config
    ConfigureFormatting config