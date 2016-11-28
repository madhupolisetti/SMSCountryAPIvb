Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace SMSCountryApi
    Interface IApiActions
        Function SendSms(smsObj As Sms) As SendSmsResult

        Function GetSmsDetails(smsObj As Sms) As GetSmsCollectionDetailsResult

        Function GetSmsCollection(smsObj As Sms) As GetSmsCollectionDetailsResult

        Function SendBulkSms(smsObj As Sms) As SendSmsResult

        Function CreateCall(callObj As [Call]) As CreateCallResult

        Function CreateBulkCall(callObj As [Call]) As CreateBulkCallResult

        Function GetCallList(callObj As [Call]) As GetCallDetailsCollectionResult


        Function GetCallDetails(callObj As [Call]) As GetCallDetailsCollectionResult

        Function DisconnectCall(callObj As [Call]) As DisconnectCallResult
        Function CreateNewGroup(groupObj As Group) As GetCreateNewGroupResult


        Function GetGroupDetails(groupObj As Group) As GetGroupDetails


        Function GetGroupCollection(groupObj As Group) As GetGroupDetails

        Function UpdateGroup(GroupObj As Group) As GetUpdateGroupResult

        Function DeleteGroup(GroupObj As Group) As DeleteGroupDetails

        Function DeleteMemberfromGroup(GroupObj As Group) As GetDeleteGroupMemberDetails

        Function GetMemberDetails(groupObj As Group) As GetGroupMemberDetailsResult


        Function GetallMemberodGroup(groupObj As Group) As GetGroupMemberDetailsResult


        Function UpdateMemberDetails(GroupObj As Group) As GetUpdateMemberResult


        Function AddMembertoExistingGroup(GroupObj As Group) As GetGroupMemberDetailsResult


        Function CreateaGroupCall(groupObj As GroupCall) As GetCreateGroupCallResult


        Function GetGroupCallList() As GetGroupCallListResult


        Function GetGroupCallDetails(groupObj As GroupCall) As GetGroupCallListResult


        Function GetaParticipantDetailsFromGroupCall(groupObj As GroupCall) As GetaparticipantDetailsFromGroupCallResult


        Function GetAllParticipantDetailsFromGroupCall(groupObj As GroupCall) As GetaparticipantDetailsFromGroupCallResult

        Function PlaySoundintoGroupCall(GroupObj As GroupCall) As PlaySoundintogroupCallResult

        Function PlaySoundintoParticipantCallinGroupCall(GroupObj As GroupCall) As PlaySoundintoParticipantCallinGroupCallResult

        Function MuteAllParticipantsinaGroupCall(GroupObj As GroupCall) As GetMuteAllParticipantsinaGroupCallResult

        Function UnmuteMuteAllParticipantsinaGroupCall(GroupObj As GroupCall) As GetUnmuteMuteAllParticipantsinaGroupCall

        Function MuteParticipantsinaGroupCall(GroupObj As GroupCall) As GetMuteParticipantInaGroupcall

        Function UnmuteMuteParticipantsinaGroupCall(GroupObj As GroupCall) As GetUnmuteMuteParticipantsinaGroupCall


        Function StartRecordinginaGroupCall(GroupObj As GroupCall) As GetStartRecordinginaGroupCallResult




        Function StopAllRecordinginaGroupCall(GroupObj As GroupCall) As GetStopRecordinginaGroupCallResult

        Function StopRecordinginGroupCall(GroupObj As GroupCall) As GetStopRecordinginaGroupCallResult
        Function GetRecordingDetailsOfaGroupCall(groupObj As GroupCall) As GetRecordingDetailsOfaGroupCallRecord


        Function GetAllRecordingDetailsOfaGroupCall(groupObj As GroupCall) As GetRecordingDetailsOfaGroupCallRecord

        Function DeleteRecordingOfGroupCall(GroupObj As GroupCall) As DeleteRecordingOfGroupCallResult

        Function DeleteAllRecordingOfGroupCall(GroupObj As GroupCall) As DeleteAllRecordingOfGroupCallResult

        Function DisconnectAllParticitantFromGroupCall(GroupObj As GroupCall) As GetAllDisconnectParticitantFromGroupCallResult

        Function DisconnectParticitantFromGroupCall(GroupObj As GroupCall) As GetDisconnectParticitantFromGroupCallResult
    End Interface
End Namespace

