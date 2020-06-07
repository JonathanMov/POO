﻿using System;

namespace Productos {
    /// <summary>
    /// Definicion de tiempo de vida de precio de un producto perecedero
    /// </summary>
    class PrecioFechaP:PrecioFecha {
        public PrecioFechaP():base() { }
        /// <summary>
        /// Creacion de un precio con tiempo límite de máximo 15 dias.
        /// </summary>
        /// <param name="f_Inicio">Fecha de inicio de tiempo límite</param>
        /// <param name="precio">Precio de arranque</param>
        public PrecioFechaP(DateTime f_Inicio, double precio) : base(f_Inicio,precio) {
            Aumenta(15);
        }
        /// <summary>
        /// Creacion de un precio con tiempo límite de máximo 15 dias.
        /// </summary>
        /// <param name="f_Inicio">Fecha de inicio de tiempo límite</param>
        /// <param name="precio">Precio de arranque</param>
        public PrecioFechaP(DateTime f_Inicio, double precio,int dias) : base(f_Inicio, precio) {
            Aumenta(dias);
        }
    }
    /// <summary>
    /// Definicion de tiempo de vida de precio de un producto no perecedero
    /// </summary>
    class PrecioFechaNP : PrecioFecha {
        public PrecioFechaNP() : base() { }
        /// <summary>
        /// Creacion de un precio con tiempo límite de máximo 30 dias.
        /// </summary>
        /// <param name="f_Inicio">Fecha de inicio de tiempo límite</param>
        /// <param name="precio">Precio de arranque</param>
        public PrecioFechaNP(DateTime f_Inicio, double precio) : base(f_Inicio, precio) {
            Aumenta(30);
        }
        /// <summary>
        /// Creacion de un precio con tiempo límite de máximo 30 dias.
        /// </summary>
        /// <param name="f_Inicio">Fecha de inicio de tiempo límite</param>
        /// <param name="precio">Precio de arranque</param>
        public PrecioFechaNP(DateTime f_Inicio, double precio,int dias) : base(f_Inicio, precio) {
            Aumenta(dias);
        }
    }
}
