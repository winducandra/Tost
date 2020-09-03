var index = 0;  
	
function LikePhoto(){ 
	setTimeout(function(){
		if(index == 0)
			document.getElementsByClassName("_9AhH0")[0].click(); // pop up photo
		
		console.log("popup photo ->", index);		
		setTimeout(function(){
		//document.getElementsByClassName('wpO6b')[2].click(); // like photo
			console.log("like photo");
			setTimeout(function(){											
				document.getElementsByClassName(" _65Bje  coreSpriteRightPaginationArrow")[0].click();// next photo
				console.log("next photo");		
				index++;							
				},10000)
			}, 8000);	 		
		if(index == 15){
			window.location.href="/";
		}	
		else
			LikePhoto();
		
	}, 6000); 	
	
}
	

LikePhoto(); 