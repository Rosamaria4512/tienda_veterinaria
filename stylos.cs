*{
    box-sizing: border-box ;
    }
    
    body
    {
    font-family: 'Roboto', sans-serif;
    font-size: 13px;
    }
    
    a
    {
        display: inline-block;
    }
    
    p
    {
        color:plum;
    }
    
    header
    {
        padding: 15px  0;
        position: fixed;
        top: 0;
        left: 0;
        z-index: 2;
        background-color: white;
        width: 100%;
    }
    
    header .container
    {
        display: flex;
        justify-content: space-between;
        align-items: center;
    }
    
    header .container .logo
    {
        width: 80px;
    }
    
    header .container a
    {
        color:aqua;
        text-decoration: none;
        margin: 0 15px;
    }
    
    header .container nav a
    {
        color: purple;
        text-decoration: none;
        margin: 0 15px;
    }
    
   /* header .container .hamb
    {
        display: none;
        position: relative;
    }*/
     footer.seccion
     {
         background-color: black;
         color:  white;
         padding-bottom: 0;
     }
    
     footer .barra-footer
     {
         background-color: gray;
         text-align: center;
         padding-right:15px ;
         padding-left: 15px;
         padding-top: 20px;
         padding-bottom: 02px;
     }
    
     footer .logo-footer
     {
         width: 100%;
     }
    
     footer p
     {
         color:white;
         margin-bottom: 30px;
     }
    
     footer a
     {
         color:white;
         text-decoration: none;   
     }
    
     footer ul
     {
        padding-left: 0;
        list-style: none;
        margin: 0;
     }
    
     footer ul li
     {
        margin-bottom: 10px;
     }
    
     
     footer .redes 
     {
       font-size: 20px;
       display: flex;
     }
    
     footer .redes a
     {
       margin: 0 7.5px;
     }
    
    .boton
    {
        text-align: center;
        text-decoration: none;
        padding: 15px 20px;
        border:none;
    }
    
    
    .boton.boton-rosado
    {
        color:pink;
        background-color: purple;
        font-size: 20px;
        font-weight: bold;
    }
    
    .boton.boton-blanco
    {
        color: palevioletred;
        background-color: white;
        font-size: 16px;
        font-weight: bold;
        border: 1px solid palevioletred;
    }
    
    .boton.boton-negro
    {
        color:white;
        background-color: black;
        font-size: 20px;
        font-weight: bold;
        
    }
    
    .boton.boton-negro:hover
    {
        color:black;
        background-color: white;
        
    }
    
    .seccion
    {
        padding-top: 60px;
        padding-bottom: 60px;
    }
    
    .cuadrado-perfecto
    {
        width: 100%;
        padding-bottom: 100%;
        position: relative;
        
    }
    
    .cuadrado-perfecto img
    {
        width: 100%;
        height: 100%;
        object-fit: cover;
        object-position: center;
        position: absolute;
        top: 0;
        left: 0;
        
    }
    
    .container
    {
        width: 1140px;
        margin: 0 auto 0 auto;
        padding-right: 15px;
        padding-left: 15px;
        position: relative;
    }
    
    .container-fluid
    {
        width: 100%;
        padding-right: 15px;
        padding-left: 15px;
        position: relative;
    }
    .row
    {
    display: flex;
    flex-wrap: wrap;
    margin-left: -15px;
    margin-right: -15px;
    }
    
    .columna
    {
        padding-right: 15px;
        padding-left: 15px;
    }
    
    .columna-25
     {
         width: 25%;
     }
    
    .columna-33
     {
         width: 33.33%;
     }
    
     
    
     .columna-41
     {
         width: 41.66%;
     }
    
     .columna-50
     {
         width: 50%;
     }
     .empujar-50
     {
         margin-left: 50%;
     }
    
     .empujar-58
     {
         margin-left: 58.33%;
     }
    
     .empujar-66
     {
         margin-left: 66.66%;
     }
    
     .empujar-0
     {
         margin-left: 0;
     }
    #inicio
    {
        position: relative;
    } 
    
    #inicio img
    {
    width: 100%;
    display: block;
    }
    
    #inicio .bloque-inicio
    {
        position: absolute;
        top: 40%;
        left: 50%;
        width: 400px;
        text-align: center;
        margin-left: -200px;
    }
    
    #inicio .bloque-inicio h1
    {
        color: white;
        font-size: 35px;
    }
    
    #inicio .bloque-inicio p
    {
        color: white;
        font-size: 16px;
    }
    

    
    #servicios .bloque-servicio
    {
        border: 1px solid grey;
    }
    
    #servicios .bloque-servicio .bloque-servicio 
    {
    
    }
    
    #servicios .bloque-servicio.bloque-servicio img
    {
        width: 100%;
    }
    
    #servicios .bloque-servicio .bloque-img-servicio.cuadrado-perfecto
    {
        padding-bottom: 56.25%;
    }
    
    #servicios .bloque-servicio .bloque-contenido-servicio 
    {
        padding: 15px;
    }
    
    #servicios .bloque-servicio .bloque-contenido-servicio  h3{
        margin-top: 0;
        font-size:  25px;
    }
    
    #productos
    {
    
    }
    
    #productos h4
    {
        padding-right: 15px;
        padding-left: 15px;
        text-align: center;
        position: absolute;
        top: 40%;
        color: white;
        font-size: 18px;
        width: 100%;
    }
    
    #productos img
    {
        filter: grayscale(1);
    }
    #productos .cuadrado-perfecto:hover img
    {
        filter: grayscale(0);
    }
    #productos .cuadrado-perfecto:hover h4
    {
    display: none;;
    }
    
    #contactenos
    {
        position:relative;
    }
    
    #contactenos iframe
    {
        position: absolute;
        top: 0;
        left: 0;
        width: 100%;
        height: 100%;
        filter: grayscale(1);
    
    }
    
    #contactenos form
    {
        padding: 60px;
        background-color: red;
    }
    
    #contactenos form .form-block
    {
    width: 100%;
    margin-bottom: 15px;
    }
    
    #contactenos form .form-block .form-control
    {
        display: block;
        height: 40px;
        font-size: 16px;
        border: 1px solid grey;
        width: 100%;
        padding: 5px 10px;
    
    }
    #contactenos form .form-block textarea
    {
        display: block;
        height: 100px;
        font-size: 16px;
        border: 1px solid grey;
        width: 100%;
        padding: 5px 10px;
    
    }
    
    #contactenos form .form-block.bloque-ultimo
    {
       margin-bottom: 0;
    
    }
    
    @media(max-width: 767px)
    {
      body 
      {
          font-size: 15px;  
      }
    
      }
      header .container nav 
      {
          position: fixed;
          width: 100%;
          height: 100%;
          background-color: white;
          padding-top: 80px;
          padding-bottom: 80px;
          padding-left: 15px;
          top: 0;
          left: 0;
          display: flex;
          flex-direction: column;
          transition: all 0.4s ease;
          transform: translateX(100%);
    
      }
    
      header .container nav.open
      {
        transform: translateX(0);
      }
    
      header .container nav a
      {
          font-size: 30px ;
          margin: 15px 0;
    
      }
    
      header .container .hamb
      {
          display:block;
          font-size: 40px;
          color: red;
          
      }
    
      form .boton.boton-negro
      {
          width: 100%;
      }
    
    footer
    {
    text-align: center;
    }
    
    footer .logo-footer
    {
        width: 50%;
    }
    
    footer .redes
    {
        justify-content: center;
    }
        .container
      {
        width: 100%;
      }
    
      .columna-mobile-100
      {
    width: 100%;
      }
    
      .columna-mobile-50
      {
          width: 50%;
      }
    
      .empujar-mobile-0
      {
          margin-left: 0;
      }
    
      .sinpadding-mobile
      {
          padding: 0;
      }
    #inicio
    {
        height: 100vh;
    }
    
    #inicio img
    {
        height: 100%;
        object-fit: cover;
        object-position: center;
    
    }
    
    #servicios .bloque-contenido
    {
    margin-bottom: 15px;
    }
    
    #contactenos
    {
        padding: 0;
    }
    #contactenos iframe
    {
        position: relative;
    }