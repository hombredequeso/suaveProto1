open Suave
open Suave.Filters
open Suave.Operators
open Suave.Successful

[<EntryPoint>]
let main argv = 
    let app =
        choose
          [ GET >=> choose
              [ path "/api/entity1" >=> OK "Hello entity1"
                path "/api/entity2" >=> OK "Hello entity2" ]
            POST >=> choose
              [ path "/api/entity1" >=> OK "post entity1"
                path "/api/entity2" >=> OK "post entity2" ] ]
    startWebServer defaultConfig app
    0
