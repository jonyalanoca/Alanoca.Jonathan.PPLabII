# ELECTRO STORE

![](https://img.shields.io/static/v1?label=Tiendaelectronica&message=v1.0&color=blue) <br>
`🧑‍💻 Jonathan Alanoca`

------------
**ElectroStore** es un programa escrito en `c# - Windows forms` que nos  permite gestinar ventas, adminstrar los productos y controlar las  ventas. 
![inicio](https://user-images.githubusercontent.com/85081072/193854384-338924a9-596e-4772-b129-7918d1b5ed66.jpg)
#### Logearse
- El programa cuenta con algunos usuarios de tipo vendedor y dueño hardcodeados.
```c#
//Vendedores
Negocio.usuariosList.Add(new Vendedor("Jonathan", "Alanoca", 37377700, "jonyalanoca2@gmail.com", "contra123", 29, dias));
Negocio.usuariosList.Add(new Vendedor("Gerardo", "Aduviri", 363734300, "geraduviri@gmail.com", "123contra", 29, dias));
Negocio.usuariosList.Add(new Vendedor("Carolina", "Osorio", 403944933, "caroosorio@gmail.com", "pass123", 25, dias));
// Dueños
Negocio.usuariosList.Add(new Dueño("Camila", "Simpson", 401231232, "camisimpson@gmail.com", "123pass"));
```
- Tambien puede autocompletar con la opción `olvidé mis datos` del dueño o vendedor segun corresponda.
- En caso de logearse como dueño inmediatamente apacen dos nuevas opciones: **Sección Ventas** y **Sección Administrar**

------------

![venta](https://user-images.githubusercontent.com/85081072/193874077-26660e14-a324-4d60-88ac-25dbf1457160.png)
### Vender
✔️El color cambia dependiendo del tipo de usuario.<br>
✔️Filtrar por categoria( **Tiene sonido**).<br>
✔️Pago con Efectivo y targeta (con recargo del 10%)<br>
✔️Registro de ventas en el historial.<br>
✔️Creación de facturas para clientes.<br>

**¿Como hacer una venta?**
1. Pulsar ```Atender al siguiente```para generar el cliente y la tabla de productos.
1. Seleccionar el producto de la lista (se puede usar el filtrado para agilizar la busqueda).
2. Definir la cantidad deseada de producto (verifique que tiene stock y el dinero del cliente).
3. Seleccionar el modo de pago efectivo o targeta(tiene racargo).
4. Pulsar ````Vender```` para finalizar la venta.

------------
![admin](https://user-images.githubusercontent.com/85081072/193877816-19954646-b9b1-4a76-8cb3-1ea39a04ca44.png)
### Administrar
✔️Filtrar por categoria<br>
✔️Ordenar por precio<br>
✔️Filtrar en un rango de precio<br>
✔️Buscar pabla o parte de palabra en la **Marca** u **Origen**.<br>
✔️Eliminar producto del Negocio.<br>
✔️Editar el producto seleccionado (Catagoria, precio o stock).<br>
✔️Agregar un nuevo producto(generico, notebook o celular).<br>

**¿Como eliminar un producto?**
1. Seleccionar el producto de la lista.
2. Darle a ```Eliminar```.
3. Confirmar la eliminación del producto.

**¿Como editar un producto?**<br>
![admin](https://user-images.githubusercontent.com/85081072/193879340-356fd726-9d69-414b-a311-d3b29aca13bb.png)
1. Seleccionar el producto de la lista.
2. Darle a ```Editar```.
3. Cambiar los datos necesarios y darle a ```Guardar datos```

**¿Como agreagar un producto?**<br>
![admin](https://user-images.githubusercontent.com/85081072/193880365-8966f9ca-ca67-4129-95b2-0359818efeb0.png)
1. Darle a ```Agregar un producto```
1. Seleccionar el tipo de producto. Dependiendo del producto seleccionado apareceran mas o menos campos para completar
1. Completar con los datos del producto. Aparecerá un ✅ cada que complete correctamente el dato.
1. Pulsar ```Agregar a la tienda```para agregar el producto. Se agregará unicamente si todos los campos han sido verificados (revisar los checks ✅)
1. Puede seguir agregando mas productos o ```Volver a adminstración```

------------


#### Historial y Factura
El historial y la factura solo se pueden ver desde la **sección ventas**. 
Tener en cuenta que se deben realizar algunas ventas para verlos reflejados
**Imagenes ilustrativas:**<br>
![admin](https://user-images.githubusercontent.com/85081072/193883125-3f835241-e6f9-4334-895f-6ee9fc44a6e8.png)<br>
![admin](https://user-images.githubusercontent.com/85081072/193882897-39c1580f-8dba-4985-bb27-702c5c114c16.png)


------------

Gracias por visitar.!<br>
Programa hecho con mucho 🧡 por **Jonathan Alanoca**<br>
Proyecto para el Segundo cuatrimestre **UTNFra**