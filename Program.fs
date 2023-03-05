open Suave
open Suave.Filters
open Suave.Operators
open Suave.Successful

let cfg = {
    defaultConfig with 
        bindings = [
            HttpBinding.createSimple HTTP "0.0.0.0" 8080
        ]
}

let app =
  choose
    [ GET >=> choose
        [ path "/hello" >=> OK "Hello GET"
          path "/goodbye" >=> OK "Good bye GET" ]
      POST >=> choose
        [ path "/hello" >=> OK "Hello POST"
          path "/goodbye" >=> OK "Good bye POST" ] ]

startWebServer cfg app