
$(document).ready(function(){

	function validateEmail(email) { 
    var re = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    return re.test(email);
	} 	 


//function for sending mail for contact-us form		
$(function () {
		 $('#formTemplate').on('submit',function (event) {
			event.preventDefault();
			 var 
				name= $("#name");
				emailid = $("#emailid"),
				message = $("#visitormessage"),							
				data = 'name=' + name.val() + '&emailid=' + emailid.val() + '&message=' + message.val();
				
				if(validateForm())
				{
				
				
					if(validateEmail(emailid.val()))
					{
						$('#submitFeedback').attr('value', 'Thanks');	
						$('#submitFeedback').attr('disabled','disabled');
						 $('#formTemplate')[0].reset();
						$.ajax({
						
						'url': 'mail.php', 
						'type': 'POST',
						'data': data,     
						'success': function (data) {									
										}
					});					
				}
				else
				{	
					$('#errEmail').text('Please enter valid email.');
					$('#errEmail').css({'opacity':'1'});
					$('#emailid').css({'border':'solid #7bff1e 2px'});
					
				}
				}
			
		});
		$("input").focus(function(){
			 var isDisabled = $('#submitFeedback').is(':disabled');
			 if (isDisabled) {
					$('#submitFeedback').attr('value', 'SEND');	
					$('#submitFeedback').attr('disabled',false);
				}
		});
	});		
});


function validateForm()
{
	var
		name= $("#name");
		emailid = $("#emailid"),
		message = $("#visitormessage");
	
	if(name.val() == "")
	{	
		$('#errName').css({'opacity':'1'});
		$('#name').css({'border':'solid #7bff1e 2px'});
		return false;
	}
	if(emailid.val() == "")
	{	
		$('#errEmail').text('Please fill out this field.');
		$('#errEmail').css({'opacity':'1'});
		$('#emailid').css({'border':'solid #7bff1e 2px'});
		return false;
	}
	if(message.val() == "")
	{	
		$('#errMessage').css({'opacity':'1'});
		$('#visitormessage').css({'border':'solid #7bff1e 2px'});
		return false;
	}
	return true;
}

function resetFormFields(obj)
{
	var fieldValue = obj.value;
	var id = $(obj).attr('id');
	if(fieldValue == "" && id== 'name')
	{
		$('#errName').css({'opacity':'0'});
		$('#name').css({'border':'1px solid #cccccc'});
	}
	if(fieldValue == "" && id== 'emailid')
	{
		$('#errEmail').css({'opacity':'0'});
		$('#emailid').css({'border':'1px solid #cccccc'});
	}
	if(fieldValue != "" && id== 'emailid')
	{
		$('#errEmail').css({'opacity':'0'});
		$('#emailid').css({'border':'1px solid #cccccc'});
	}
	if(fieldValue == "" && id== 'visitormessage')
	{ 
		$('#errMessage').css({'opacity':'0'});
		$('#visitormessage').css({'border':'1px solid #cccccc'});
	}
}