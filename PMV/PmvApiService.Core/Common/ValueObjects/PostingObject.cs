using PMV.PmvApiService.Core.BaseEntity;

namespace PMV.PmvApiService.Core.Common.ValueObjects;

public class PostingObject : ValueObject
{

    public static PostingObject Posted() {
        
        return new PostingObject {
            IsPosted = true,
            PostedAt = DateTime.Now
        };
    }

    public static PostingObject Create(bool isPosted,DateTime? postedAt = null) {
        return new PostingObject {
            IsPosted = isPosted,
            PostedAt = postedAt
        };
    }
    
    public bool IsPosted { get; private set; } = false;
    public DateTime? PostedAt { get; private set; } = null;

    

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return IsPosted;
        yield return PostedAt;
    }
}
