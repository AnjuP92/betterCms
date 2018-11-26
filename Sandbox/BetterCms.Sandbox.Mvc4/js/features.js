
String.prototype.filename=function(extension){
    var s= this.replace(/\\/g, '/');
    s= s.substring(s.lastIndexOf('/')+ 1);
    return extension? s.replace(/[?#].+$/, ''): s.split('.')[0];
}


var isClicked = false;


function changeImageAndCallOut(obj)
{ 
	
	var parentDivImg = $('#featureImage');
	var parentDiv= $('#featureBackground');
	var videoPlayer = $('#myVideo');
	var videoImages = $('#videoImages');	
	$("#myVideo").bind('timeupdate', onVideoTimeupdate);
		if($(obj).attr('id') == 'hdCalloutImg')
		{		
					
			parentDiv.find('div').each( function ()
			{		
					
                $(this).addClass('hideCalloutDisplay');		
			
			});
            videoImages.find('img').each( function ()
			{		
				$(this).removeClass('showImage');
               
                $(this).addClass('hideImage');		
			
			});
			$('#hdCallout').removeClass('bounce');
			$('#hdCallout').addClass('hideCallout');	
			parentDivImg.removeClass('featureImageAnimation');				
			parentDivImg.addClass('featureImageAnimationZoomOut');			
			parentDivImg.attr('src','images/device1.png');		
			 $('#featureBackground').css({"text-align":"left"});
			  $('#featureBackground').css({"margin-top":"0"});
			    $('#featureBackground').css({"padding-left":"0"});
			  
			setTimeout(function(){				
				parentDivImg.addClass('hideImage');
                $('#hdVideos').removeClass('hideImage');
				$('#hdVideos').addClass('showImage');
              
				videoPlayer.attr("src", "https://nyceprod.blob.core.windows.net/production/videos/corpweb/intro.mp4");		
				$("#myVideo")[0].play();
				$('#videoPlayer').css({'display':'block'});
				
					
				}
			,1050);		
			
			
			
		}
		
		if($(obj).attr('id') == 'keyCallOutImg')
		{		
					
			parentDiv.find('div').each( function ()
			{					
					$(this).addClass('hideCalloutDisplay');				
			});
             videoImages.find('img').each( function ()
			{		
				 $(this).removeClass('showImage');	
                $(this).addClass('hideImage');		
			
			});
			$('#keyCallOut').removeClass('bounce');
			$('#keyCallOut').addClass('hideCallout');	
			parentDivImg.removeClass('featureImageAnimation');				
			parentDivImg.addClass('featureImageAnimationZoomOut');			
			parentDivImg.attr('src','images/device1.png');		
			 $('#featureBackground').css({"text-align":"left"});
			   $('#featureBackground').css({"margin-top":"0"});
			      $('#featureBackground').css({"padding-left":"0"});
			setTimeout(function(){				
				parentDivImg.addClass('hideImage');
				$('#keywordsPlay').removeClass('hideImage');                
				$('#keywordsPlay').addClass('showImage');
				videoPlayer.attr("src", "https://nyceprod.blob.core.windows.net/production/videos/corpweb/keywords.mp4");
				  $("#myVideo")[0].play();
					$('#videoPlayer').css({'display':'block'});
					
				}
			,1050);		
			
		}
		
		if($(obj).attr('id') == 'transCallOutImg')
		{		
					
			parentDiv.find('div').each( function ()
			{					
					$(this).addClass('hideCalloutDisplay');				
			});
             videoImages.find('img').each( function ()
			{		
				 $(this).removeClass('showImage');	
                $(this).addClass('hideImage');		
			
			});
			$('#transCallOut').removeClass('bounce');
			$('#transCallOut').addClass('hideCallout');	
			parentDivImg.removeClass('featureImageAnimation');				
			parentDivImg.addClass('featureImageAnimationZoomOut');			
			parentDivImg.attr('src','images/device1.png');		
			 $('#featureBackground').css({"text-align":"left"});
			   $('#featureBackground').css({"margin-top":"0"});
			      $('#featureBackground').css({"padding-left":"0"});
			setTimeout(function(){				
				parentDivImg.addClass('hideImage');
				$('#translationFeature').removeClass('hideImage');                
				$('#translationFeature').addClass('showImage');
				videoPlayer.attr("src", "https://nyceprod.blob.core.windows.net/production/videos/corpweb/translation.mp4");
				  $("#myVideo")[0].play();
					$('#videoPlayer').css({'display':'block'});
					 
				}
			,1050);		
			
		}
		
		if($(obj).attr('id') == 'voiceCallOutImg')
		{		
						
			parentDiv.find('div').each( function ()
			{					
					$(this).addClass('hideCalloutDisplay');				
			});
             videoImages.find('img').each( function ()
			{		
				 $(this).removeClass('showImage');	
                $(this).addClass('hideImage');		
			
			});
			$('#voiceCallOut').removeClass('bounce');
			$('#voiceCallOut').addClass('hideCallout');	
			parentDivImg.removeClass('featureImageAnimation');				
			parentDivImg.addClass('featureImageAnimationZoomOut');			
			parentDivImg.attr('src','images/device1.png');		
			 $('#featureBackground').css({"text-align":"left"});
			   $('#featureBackground').css({"margin-top":"0"});
			      $('#featureBackground').css({"padding-left":"0"});
			setTimeout(function(){				
				parentDivImg.addClass('hideImage');
				$('#voiceRecording').removeClass('hideImage');                
				$('#voiceRecording').addClass('showImage');
				videoPlayer.attr("src", "https://nyceprod.blob.core.windows.net/production/videos/corpweb/recording.mp4");
				  $("#myVideo")[0].play();
					$('#videoPlayer').css({'display':'block'});
					
					
				}
			,1050);		
			
		}
		
		if($(obj).attr('id') == 'lineCallOutImg')
		{		
				
			parentDiv.find('div').each( function ()
			{					
					$(this).addClass('hideCalloutDisplay');				
			});	
             videoImages.find('img').each( function ()
			{		
				 $(this).removeClass('showImage');	
                $(this).addClass('hideImage');		
			
			});
			$('#lineCallOut').removeClass('bounce');
			$('#lineCallOut').addClass('hideCallout');	
			parentDivImg.removeClass('featureImageAnimation');				
			parentDivImg.addClass('featureImageAnimationZoomOut');			
			parentDivImg.attr('src','images/device1.png');		
			 $('#featureBackground').css({"text-align":"left"});
			   $('#featureBackground').css({"margin-top":"0"});
			      $('#featureBackground').css({"padding-left":"0"});
			setTimeout(function(){				
				parentDivImg.addClass('hideImage');
				$('#showLines').removeClass('hideImage');                
				$('#showLines').addClass('showImage');
				videoPlayer.attr("src", "https://nyceprod.blob.core.windows.net/production/videos/corpweb/line.mp4");
				  $("#myVideo")[0].play();
					$('#videoPlayer').css({'display':'block'});
					 
				}
			,1050);		
			
		}
		
		if($(obj).attr('id') == 'progressCallOutImg')
		{		
		
			parentDiv.find('div').each( function ()
			{					
					$(this).addClass('hideCalloutDisplay');				
			});	
             videoImages.find('img').each( function ()
			{		
				 $(this).removeClass('showImage');	
                $(this).addClass('hideImage');		
			
			});
			$('#progressCallOut').removeClass('bounce');
			$('#progressCallOut').addClass('hideCallout');	
			parentDivImg.removeClass('featureImageAnimation');				
			parentDivImg.addClass('featureImageAnimationZoomOut');			
			parentDivImg.attr('src','images/device1.png');	
            $('#featureBackground').css({"margin-top":"0"});			
            $('#featureBackground').css({"text-align":"left"});
            $('#featureBackground').css({"padding-left":"0"});
			setTimeout(function(){				
				parentDivImg.addClass('hideImage');
				$('#progressRecording').removeClass('hideImage');               
				$('#progressRecording').addClass('showImage');
				videoPlayer.attr("src", "https://nyceprod.blob.core.windows.net/production/videos/corpweb/progress.mp4");
				  $("#myVideo")[0].play();
					$('#videoPlayer').css({'display':'block'});
					 
				}
			,1050);		
			
		}
		
}


function resetToInitialOnClick()
{	
	//if($('#temp').hasClass="showImage")
	//{
		 $('#myVideo').attr("src", "");
		 $('#videoImages').find('img').each( function ()
			{		
				 $(this).removeClass('showImage');	
                $(this).addClass('hideImage');		
			
			});
		 $('#featureBackground').find('div').each(function(){
			 $(this).addClass('bounce');
			  $(this).addClass('hideCallout');
			  
		 });
		
		
		
		
		$('#featureBackground').css({"margin-top":"50px"});
		   $('#featureBackground').css({"padding-left":"20px"});
		$('#temp').removeClass('showImage');	
		$('#temp').addClass('hideImage');
	
		//$('#featureImage').attr('src','images/device1.png')
		 $('#featureBackground').css({"text-align":"center"});
		$('.bounce').removeClass('hideCalloutDisplay');	
		$('#videoPlayer').css({'display':'none'});
		$('#featureImage').removeClass('featureImageAnimationZoomOut');			
		$('#featureImage').removeClass('hideImage');	
		$("#featureImage").removeClass('featureImage');
		$('#featureImage').addClass('ShowImage');		
		$("#featureImage").addClass('featureImageAnimation');
		setTimeout(function(){	$('.bounce').removeClass('hideCallout');},50);
		
			
	//}
}

function featureInitial()
{
	
	$('#videoPlayer').click(function(){
		isClicked = false;
		
	});
	
	
	if(isClicked)
	{	
		if($('#featureImage').attr('src').filename()!="device1")
		{	
			resetToInitialOnClick();				
		}
	}
	else
	{
		setTimeout(function() {isClicked=true;},1500);
	}

}
function onVideoTimeupdate() {
if(this.duration>0)
{	
    if (this.currentTime >= this.duration) {
      
      
			var v = this.currentSrc;
        this.src = '';
        this.src = v;
    }
}
}

$(document).ready(function(){
	
	  //if ($.browser.msie && $.browser.version <10) 
	  //  {
      //     $('#feature').css({'display': 'none'});
	  //      $('#feature-mobile').css({'display': 'none'});
	  //  	      $('#featureIE').css({'display': 'block'});
	  //  	$('img').css({'border':'none'},{'outline':'none'});
	  //  	$('a').css({'border':'none'},{'outline':'none'});
	  //  }
		
		

	
});

