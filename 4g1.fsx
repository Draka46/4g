#load "vec2d.fs"
//#r "Colors.dll"
open System

printfn "White-box testing of vex2d.fsx"
printfn "Unit : len"
printfn "Test 1 : %5b | len (4,0) = 4" (vec2d.len (4.0, 0.0) = 4.0)
printfn "Test 2 : %5b | len (0,6) = 6" (vec2d.len (0.0, 6.0) = 6.0)
printfn "Test 3 : %5b | len (sqrt(10), sqrt(15)) = 5" (vec2d.len (sqrt 10.0, sqrt 15.0) = 5.0)
printfn "Test 4 : %5b | len (sqrt(5), sqrt(11)) = 4" (vec2d.len (sqrt 5.0, sqrt 11.0) = 4.0)

/// My inverse tangent tool (Microsoft Mathematics) keeps disagreeing with the program about results of tan^(-1)
printfn "Unit : ang"
printfn "Test 1 : %5b | ang (4, pi) = pi/4 | ang (4, pi): %A | pi/4: %A" (vec2d.ang (4.0, Math.PI) = (Math.PI/4.0)) (vec2d.ang (4.0, Math.PI)) (Math.PI/4.0)

printfn "Unit : scale"
printfn "Test 1 : %5b | scale 2 (4,0) = (8,0)" (vec2d.scale 2.0 (4.0, 0.0) = (8.0, 0.0))

printfn "Unit : add"
printfn "Test 1 : %5b | add (4,0) (2,0) = (6,0)" (vec2d.add (4.0, 0.0) (2.0, 0.0) = (6.0, 0.0))

printfn "Unit : dot"
printfn "Test 1 : %5b | dot (4,0) (2,0) = (6,0)" (vec2d.dot (4.0, 0.0) (2.0, 0.0) = 8.0)

// printfn "  %5b: Branch 1a" (...)