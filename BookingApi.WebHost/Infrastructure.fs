namespace Piter.Samples.Booking.HttpApi.HttpHost

open System
open System.Web.Http
open Piter.Samples.Booking.HttpApi.Infrastructure

type Global() =
    inherit System.Web.HttpApplication()
    member this.Application_Start ( sender : obj ) ( e : EventArgs ) = 
        Configure GlobalConfiguration.Configuration