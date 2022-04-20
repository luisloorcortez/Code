
interface IAnimalesDeportes
{
    string TipoDeporte(string Deporte);
    bool EsOlimpico(bool Respuesta);
}
/*
Existen duplicidad me metodo, para eso usamos a la llamada al métodos con la nomenclatura del punto. 
TipoDeporte.IAnimalesDeportes, todo sin poner el indicador de acceso. 

Además podemos usar la interface con el metodo de tranferencia de una clase superior. 
Los métodos dentro de las interfaces son abastractos 
*/