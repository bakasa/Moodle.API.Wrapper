using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moodle.API.Wrapper.Models.Mod;

namespace Moodle.API.Wrapper.Controllers.Mod
{
	public sealed class Scorm : BaseController
	{

		public Scorm() : base()
		{
		}

		public Scorm(string token, string url) : base(token, url)
		{
		}

		public ScormAttemptCountModel GetScormAttemptCount(ScormAttemptCountInputModel scormAttemptCountInputModel)
		{
			return Post<ScormAttemptCountModel,ScormAttemptCountInputModel>("mod_scorm_get_scorm_attempt_count", scormAttemptCountInputModel);
		}

		public ScormsByCoursesModel GetScormsByCourses(DeleteCoursesInputModel deleteCoursesInputModel)
		{
			return Post<ScormsByCoursesModel,DeleteCoursesInputModel>("mod_scorm_get_scorms_by_courses", deleteCoursesInputModel);
		}

		public ScormScoesModel GetScormScoes(ScormScoesInputModel scormScoesInputModel)
		{
			return Post<ScormScoesModel,ScormScoesInputModel>("mod_scorm_get_scorm_scoes", scormScoesInputModel);
		}

		public ScormScoTracksModel GetScormScoTracks(ScormScoTracksInputModel scormScoTracksInputModel)
		{
			return Post<ScormScoTracksModel,ScormScoTracksInputModel>("mod_scorm_get_scorm_sco_tracks", scormScoTracksInputModel);
		}

		public ScormUserDataModel GetScormUserData(ScormUserDataInputModel scormUserDataInputModel)
		{
			return Post<ScormUserDataModel,ScormUserDataInputModel>("mod_scorm_get_scorm_user_data", scormUserDataInputModel);
		}

		public InsertScormTracksModel InsertScormTracks(InsertScormTracksInputModel insertScormTracksInputModel)
		{
			return Post<InsertScormTracksModel,InsertScormTracksInputModel>("mod_scorm_insert_scorm_tracks", insertScormTracksInputModel);
		}

		public MarkCourseSelfCompletedModel LaunchSco(LaunchScoInputModel launchScoInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,LaunchScoInputModel>("mod_scorm_launch_sco", launchScoInputModel);
		}

		public MarkCourseSelfCompletedModel ViewScorm(ViewScormInputModel viewScormInputModel)
		{
			return Post<MarkCourseSelfCompletedModel,ViewScormInputModel>("mod_scorm_view_scorm", viewScormInputModel);
		}

		//Function Placeholder

	}
}