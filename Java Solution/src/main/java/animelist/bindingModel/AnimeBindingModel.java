package animelist.bindingModel;

public class AnimeBindingModel {
    //TODO: Implement me ...

    //@NotNull
    private Integer rating;

    //@NotNull
    private String name;

    //@NotNull
    private String description;

    //@NotNull
    private String watched;

    public AnimeBindingModel() {
    }

    public Integer getRating() {
        return this.rating;
    }

    public void setRating(Integer rating) {
        this.rating = rating;
    }

    public String getName() {
        return this.name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getDescription() {
        return this.description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public String getWatched() {
        return this.watched;
    }

    public void setWatched(String watched) {
        this.watched = watched;
    }

    //TODO: Implement me ... END
}
