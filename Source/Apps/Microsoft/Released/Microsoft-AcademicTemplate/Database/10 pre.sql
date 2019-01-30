SET ANSI_NULLS              ON;
SET ANSI_PADDING            ON;
SET ANSI_WARNINGS           ON;
SET ANSI_NULL_DFLT_ON       ON;
SET CONCAT_NULL_YIELDS_NULL ON;
SET QUOTED_IDENTIFIER       ON;
go

-- Must be executed inside the target database

-- Regular views

-- Tables 
-- Staging
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='ak' AND TABLE_NAME='PaperStaging' AND TABLE_TYPE='BASE TABLE')
    DROP TABLE ak.PaperStaging;
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='ak' AND TABLE_NAME='AuthorStaging' AND TABLE_TYPE='BASE TABLE')
    DROP TABLE ak.AuthorStaging;
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='ak' AND TABLE_NAME='JournalStaging' AND TABLE_TYPE='BASE TABLE')
    DROP TABLE ak.JournalStaging;
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='ak' AND TABLE_NAME='FieldsOfStudyStaging' AND TABLE_TYPE='BASE TABLE')
    DROP TABLE ak.FieldsOfStudyStaging;
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='ak' AND TABLE_NAME='ConferenceStaging' AND TABLE_TYPE='BASE TABLE')
    DROP TABLE ak.ConferenceStaging;
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='ak' AND TABLE_NAME='AffiliationStaging' AND TABLE_TYPE='BASE TABLE')
    DROP TABLE ak.AffiliationStaging;
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='ak' AND TABLE_NAME='PaperAuthorAffiliationRelationshipStaging' AND TABLE_TYPE='BASE TABLE')
    DROP TABLE ak.PaperAuthorAffiliationRelationshipStaging;
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='ak' AND TABLE_NAME='PaperFieldsOfStudyRelationshipStaging' AND TABLE_TYPE='BASE TABLE')
    DROP TABLE ak.PaperFieldsOfStudyRelationshipStaging;
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='ak' AND TABLE_NAME='PaperCitationRelationshipStaging' AND TABLE_TYPE='BASE TABLE')
    DROP TABLE ak.PaperCitationRelationshipStaging;



-- Prod Tables
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='ak' AND TABLE_NAME='Configuration' AND TABLE_TYPE='BASE TABLE')
    DROP TABLE ak.[Configuration];
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='ak' AND TABLE_NAME='Date' AND TABLE_TYPE='BASE TABLE')
    DROP TABLE ak.[Date];

IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='ak' AND TABLE_NAME='Paper' AND TABLE_TYPE='BASE TABLE')
    DROP TABLE ak.Paper;
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='ak' AND TABLE_NAME='Author' AND TABLE_TYPE='BASE TABLE')
    DROP TABLE ak.Author;
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='ak' AND TABLE_NAME='Journal' AND TABLE_TYPE='BASE TABLE')
    DROP TABLE ak.Journal;
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='ak' AND TABLE_NAME='FieldsOfStudy' AND TABLE_TYPE='BASE TABLE')
    DROP TABLE ak.FieldsOfStudy;
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='ak' AND TABLE_NAME='Conference' AND TABLE_TYPE='BASE TABLE')
    DROP TABLE ak.Conference;
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='ak' AND TABLE_NAME='Affiliation' AND TABLE_TYPE='BASE TABLE')
    DROP TABLE ak.Affiliation;
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='ak' AND TABLE_NAME='PaperAuthorAffiliationRelationship' AND TABLE_TYPE='BASE TABLE')
    DROP TABLE ak.PaperAuthorAffiliationRelationship;
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='ak' AND TABLE_NAME='PaperFieldsOfStudyRelationship' AND TABLE_TYPE='BASE TABLE')
    DROP TABLE ak.PaperFieldsOfStudyRelationship;
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA='ak' AND TABLE_NAME='PaperCitationRelationship' AND TABLE_TYPE='BASE TABLE')
    DROP TABLE ak.PaperCitationRelationship;

-- Stored Procs
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.ROUTINES WHERE ROUTINE_SCHEMA='ak' AND ROUTINE_NAME='Merge' AND ROUTINE_TYPE='PROCEDURE')
    DROP PROCEDURE ak.[Merge];



IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name='ak')
BEGIN
    EXEC ('CREATE SCHEMA ak AUTHORIZATION dbo'); -- Avoid batch error
END;

