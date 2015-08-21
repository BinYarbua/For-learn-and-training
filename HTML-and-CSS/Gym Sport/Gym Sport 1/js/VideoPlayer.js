var VP = VP ||{};

var videoPlayer =$('#videoPlayer')[0];

var barSize=new Number(450);
var volumeBar=new Number(32);

var playPauseBtn=$('#playPauseBtn')[0];
var volumeBtn=$('#volumeIcon')[0];
var volumeContainer=$('#volumeBarContainer')[0];
var volumeBar=$('.volumeBar')[0];
var scrubberContainer=$('#scurbberContainer')[0];
var scrubberBar =$('#scrubberBar')[0];
var fullscreen=$('#fullscreen')[0];
var config=$('#config')[0];

var updatePlayer;
var upTimer;


VP.init=function(){
	playPauseBtn.addEventListener('click',VP.togglePlayPause,false);
	scrubberContainer.addEventListener('click',VP.scrubberClicked,false);
	videoPlayer.addEventListener('timeupdate',VP.updateTimer);
}
VP.togglePlayPause=function(){
	if(!videoPlayer.paused && !videoPlayer.ended)
	{
		videoPlayer.pased();
		$('#playPauseBtn').html('<i class="fa fa-pause"></i>');
		window.clearInterval(updatePlay);
		window.clearInterval(upTimer);
	}
	else
	{
		videoPlayer.play();
		$('#playPauseBtn').html('paused');
		function loop(){
			VP.updateScrubber()
		};
		updatePlayer.setInterval(loop,100);
	}
};
VP.updateScrubber=function()
{
	if(!videoPlayer.ended)
	{
		var size=parseInt(videoPlayer.currentTime*barSize/videoPlayer.duration);
		$('#scrubberBar').css('width',size +'px');
	}
	else
	{
		$('#scrubberBar').css('width','0px');
		$('#playPauseBtn').html('<i class="fa fa-play-circle-o"></i>');
		window.clearInterval(updatePlay);
	}
};
VP.scrubberClicked=function(e)
{
	if (!videoPlayer.pauesd && !videoPlayer.ended)
	{
		var mouseX =e.pageX - scrubberContainer.offsetleft;
		var newTime = mouseX * videoPlayer.duration/barSize;
		videoPlayer.currentTime = newTime;
		$('#scrubberBar').css('width',mouseX + 'px');
	}
};
VP.upTimer =function()
{
	var eTime;
	var tTime;

	//calculate elapsed time
	var eSeconds =Math.round(videoPlayer.currentTime);
	var eMinutes= Math.round(eSeconds/60);
	eMinutes =(eMinutes >=10)?eMinutes:"0" +  eMinutes;
	eSeconds =Math.floor(eSeconds%60);
	eSeconds =(eSeconds >=10)?eSeconds:"0" +eSeconds;

	//calculate total time
	var tSeconds =Math.round(videoPlayer.currentTime);
	var tMinutes= Math.round(tSeconds/60);
	tMinutes =(tMinutes >=10)?tMinutes:"0" +  tMinutes;
	tSeconds =Math.floor(tSeconds%60);
	tSeconds =(tSeconds >=10)?tSeconds:"0" +tSeconds;

	//assign these values to out variable
	eTime = ''+ eMinutes + ':' +eSeconds;
	tTime = ''+ tMinutes + ':' +eSeconds;

	//display in timer
	$('#timer').html('' + eTime + '/'+tTime);
};