# SeguimientoPaquetes
Proyecto : Sistema de seguimiento de paquetes
Programación III , Proyecto # 1

Objetivo del sistema:
	1.	Controlar el seguimiento de paquetes que se trasladan por la empresa
	2.	Manejar los costos de impuestos, transporte  y otros
	3.	Controlar la informacion de:
		a.	Clentes 
		b.	Tarjetas para pago automatic
		c.	Direccion de entrega

Caracteristicas del Sistema:
	1.	Control de seguridad y manejo de perfiles (login, sesiones y atributos por sesiones) [consulta tablas]
	2.	Modulo de mantenimiento de las tablas  para base de datos [leer, escribir y eliminar]
	3.	Modulo de consulta de usuarios (debe enlazar las tablas usuario, pedidos, estado de usuario) [permso solo de lectura]
	4.	Para los pedidos (table) se debe tener los estados de (recibido en punto, en avion, terrestre, maritime) {punto inicial, en transporte, en tramite aduana, camino a sucursal, disponible para retiro}
	5.	Formulario para ingresar los pedidos y su estado inicial y su estado final (inicial: empresa, final: sucursal)[table para sucursales] cambiar el estado del paquete segun corresponda
	6.	Modulo de consultas :
		a.	Listado usuarios activos
		b.	Seguimiento de paquetes por id de cliente o codigo unico de paquete
		c.	Informacion de register del ciente por ID o nombre.
