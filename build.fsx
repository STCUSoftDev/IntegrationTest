#I @"C:\Tools\FAKE\tools"
#r "FakeLib"
#I @"C:\Tools\StcuFake"
#r "StcuFake"
open Fake
open STCU
BuildCore.DefineDefaultTargets ()

"BuildAll" ==> "Continuous"

BuildCore.RunTargetOrContinuous ()
