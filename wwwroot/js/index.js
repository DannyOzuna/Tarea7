function msjAlert(title, icon){
    Swal.fire({
        //position: 'top-end',
        icon,
        title,
        showConfirmButton: false,
        timer: 1500
      })
}

function msjConfim(title,text,icon){
    return new Promise (resolve => {
        Swal.fire({
            title,
            text,
            icon,
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            cancelButtonText: 'Cancelar',
            confirmButtonText: '¡Sí, bórralo!'
          }).then((result) => {
              resolve(result.isConfirmed);
          })
    })
}

//Funcion mascara para los elementos (http://javascript.tunait.com/javascript/?s=mascara#codigo).
function mascara(d,sep,pat,nums){
    if(d.valant != d.value){
        val = d.value
        largo = val.length
        val = val.split(sep)
        val2 = ''
        for(r=0;r<val.length;r++){
            val2 += val[r]
        }
        if(nums){
            for(z=0;z<val2.length;z++){
                if(isNaN(val2.charAt(z))){
                    letra = new RegExp(val2.charAt(z),"g")
                    val2 = val2.replace(letra,"")
                }
            }
        }
        val = ''
        val3 = new Array()
        for(s=0; s<pat.length; s++){
            val3[s] = val2.substring(0,pat[s])
            val2 = val2.substr(pat[s])
        }
        for(q=0;q<val3.length; q++){
            if(q ==0){
                val = val3[q]
            }
            else{
                if(val3[q] != ""){
                    val += sep + val3[q]
                    }
            }
        }
        d.value = val
        d.valant = val
    }
}//Fin de la funcion mascara para los elementos.