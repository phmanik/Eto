﻿namespace EtoApp.1.Desktop
module Program =

    open System
    open EtoApp.1

    [<EntryPoint>]
    [<STAThread>]
    let Main(args) = 
        let app = new Eto.Forms.Application(Eto.Platform.Detect)
        app.Run(new MainForm())
        0