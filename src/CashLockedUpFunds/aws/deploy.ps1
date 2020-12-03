param(
    [String]$tenant,
    [String]$deployment,
    [String]$version,
    [String]$awsaccesskey,
    [String]$awssecretkey,
    [String]$projectName,
    [String]$clusterConfigName,
    [String]$profileName,
    [String]$clusterName
)
$env:TENANT = $tenant
$env:DEPLOYMENT = $deployment
$env:VERSION = $version

Write-Output "Start deploying task to ecs"

C:\EcsCli\ecs-cli.exe configure `
    --cluster $clusterName `
    --region eu-west-1 `
    --default-launch-type EC2 `
    --config-name $clusterConfigName

C:\EcsCli\ecs-cli.exe configure profile `
    --profile-name $profileName `
    --access-key $awsaccesskey `
    --secret-key $awssecretkey

C:\EcsCli\ecs-cli.exe compose `
    --project-name $projectName `
    --cluster-config $clusterConfigName `
    --ecs-profile $profileName `
    service up `
    --deployment-min-healthy-percent 0 `


Write-Output "Done deploying task to ecs"