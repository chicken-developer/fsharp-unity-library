namespace ActionRPG

open UnityEngine

type TestFuture() =
   inherit MonoBehaviour()
   
   [<SerializeField>]
   [<DefaultValue>] val mutable _informationText : GameObject

    member this.Start() = 
        Debug.Log("Say hello from FSharp ")

    member this.Update() = 
        Debug.Log("hello man")

