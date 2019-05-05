# Script used to set the NuGet package version in Azure DevOps

$versionPrefix = "1.0.0"
$versionSuffix = ""
$versionFile = $versionPrefix + "." + ${env:BUILD_BUILDNUMBER}
$versionProduct = $versionPrefix;

if (${env:BUILD_REASON} -eq "PullRequest") {
    $versionPrefix = $versionPrefix + "." + ${env:BUILD_BUILDNUMBER}
    $pullRequestNumber = ${env:SYSTEM_PULLREQUEST_PULLREQUESTNUMBER}
    if ($pullRequestNumber -eq "") {
        $pullRequestNumber = ${env:SYSTEM_PULLREQUEST_PULLREQUESTID}
    }
    $versionSuffix = "PR" + $pullRequestNumber
}

Write-Host "VersionPrefix = $versionPrefix"
Write-Host "VersionSuffix = $versionSuffix"
Write-Host "VersionFile = $versionFile"
Write-Host "VersionProduct = $versionProduct"

Write-Host "##vso[task.setvariable variable=VersionPrefix]$versionPrefix"
Write-Host "##vso[task.setvariable variable=VersionSuffix]$versionSuffix"
Write-Host "##vso[task.setvariable variable=VersionFile]$versionFile"
Write-Host "##vso[task.setvariable variable=VersionProduct]$versionProduct"
